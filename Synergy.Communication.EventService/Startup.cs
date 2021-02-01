using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Synergy.Communication.EventService.BLL;
using Synergy.Communication.EventService.BLL.Interfaces;
using Synergy.Communication.EventService.Configuration;
using Synergy.Communication.EventService.DBContexts;
using Synergy.Communication.EventService.Repository;
using Synergy.Communication.EventService.Repository.Interfaces;

namespace Synergy.Communication.EventService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<EventServiceDbContext>(p => p.UseNpgsql(Configuration.GetConnectionString(ConnectionStrings.EventServiceConnectionString)));

            var idpConfiguration = Configuration.GetSection(nameof(IdpConfiguration)).Get<IdpConfiguration>();
            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = idpConfiguration.Authority;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false
                    };
                });

            services.AddTransient<IEventServiceBLL, EventServiceBLL>();
            services.AddTransient<IEventRepository, EventRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // This will make the HTTP requests log as rich logs instead of plain text.
            app.UseSerilogRequestLogging(); 

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
