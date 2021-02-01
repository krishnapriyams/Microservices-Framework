using Microsoft.EntityFrameworkCore;
using Synergy.Communication.EventService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.DBContexts
{
    public class EventServiceDbContext : DbContext
    {
        public EventServiceDbContext(DbContextOptions<EventServiceDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Data set for events
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Data set for application identities
        /// </summary>
        public DbSet<ApplicationIdentity> ApplicationIdentities { get; set; }
    }
}
