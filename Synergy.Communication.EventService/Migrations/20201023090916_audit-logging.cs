using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.Communication.EventService.Migrations
{
    public partial class auditlogging : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_events",
                schema: "public",
                table: "events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationIdentities",
                table: "ApplicationIdentities");

            migrationBuilder.DropColumn(
                name: "Source",
                schema: "public",
                table: "events");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "ApplicationIdentities");

            migrationBuilder.RenameTable(
                name: "events",
                schema: "public",
                newName: "published_events",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "ApplicationIdentities",
                newName: "applications",
                newSchema: "public");

            migrationBuilder.RenameColumn(
                name: "Status",
                schema: "public",
                table: "published_events",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Data",
                schema: "public",
                table: "published_events",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "published_events",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "published_events",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Type",
                schema: "public",
                table: "published_events",
                newName: "event_type");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "published_events",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ApplicationIdentifier",
                schema: "public",
                table: "published_events",
                newName: "app_identifier");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "applications",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VesselIMO",
                schema: "public",
                table: "applications",
                newName: "vessel_imo");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                schema: "public",
                table: "applications",
                newName: "tenant_id");

            migrationBuilder.AlterColumn<short>(
                name: "status",
                schema: "public",
                table: "published_events",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "data",
                schema: "public",
                table: "published_events",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                schema: "public",
                table: "published_events",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                schema: "public",
                table: "published_events",
                type: "timestamptz",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<short>(
                name: "event_type",
                schema: "public",
                table: "published_events",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                schema: "public",
                table: "published_events",
                type: "timestamptz",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<Guid>(
                name: "app_identifier",
                schema: "public",
                table: "published_events",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "attachments",
                schema: "public",
                table: "published_events",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "event_name",
                schema: "public",
                table: "published_events",
                type: "text",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "seq_id",
                schema: "public",
                table: "published_events",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                schema: "public",
                table: "applications",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "application_id",
                schema: "public",
                table: "applications",
                type: "text",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contact_email",
                schema: "public",
                table: "applications",
                type: "text",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                schema: "public",
                table: "applications",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "notification_endpoint",
                schema: "public",
                table: "applications",
                type: "text",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "status",
                schema: "public",
                table: "applications",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                schema: "public",
                table: "applications",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_published_events",
                schema: "public",
                table: "published_events",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_applications",
                schema: "public",
                table: "applications",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TableName = table.Column<string>(nullable: true),
                    KeyValues = table.Column<string>(nullable: true),
                    OldValues = table.Column<string>(nullable: true),
                    NewValues = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Action = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_published_events",
                schema: "public",
                table: "published_events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_applications",
                schema: "public",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "attachments",
                schema: "public",
                table: "published_events");

            migrationBuilder.DropColumn(
                name: "event_name",
                schema: "public",
                table: "published_events");

            migrationBuilder.DropColumn(
                name: "seq_id",
                schema: "public",
                table: "published_events");

            migrationBuilder.DropColumn(
                name: "application_id",
                schema: "public",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "contact_email",
                schema: "public",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "created_at",
                schema: "public",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "notification_endpoint",
                schema: "public",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "status",
                schema: "public",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "updated_at",
                schema: "public",
                table: "applications");

            migrationBuilder.RenameTable(
                name: "published_events",
                schema: "public",
                newName: "events",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "applications",
                schema: "public",
                newName: "ApplicationIdentities");

            migrationBuilder.RenameColumn(
                name: "status",
                schema: "public",
                table: "events",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "data",
                schema: "public",
                table: "events",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "events",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "events",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "event_type",
                schema: "public",
                table: "events",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "events",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "app_identifier",
                schema: "public",
                table: "events",
                newName: "ApplicationIdentifier");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ApplicationIdentities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "vessel_imo",
                table: "ApplicationIdentities",
                newName: "VesselIMO");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "ApplicationIdentities",
                newName: "TenantId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "public",
                table: "events",
                type: "text",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                schema: "public",
                table: "events",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "jsonb",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                schema: "public",
                table: "events",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                schema: "public",
                table: "events",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                schema: "public",
                table: "events",
                type: "text",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "public",
                table: "events",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationIdentifier",
                schema: "public",
                table: "events",
                type: "text",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                schema: "public",
                table: "events",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ApplicationIdentities",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "AppId",
                table: "ApplicationIdentities",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_events",
                schema: "public",
                table: "events",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationIdentities",
                table: "ApplicationIdentities",
                column: "Id");
        }
    }
}
