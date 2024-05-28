using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MextFullstackSaaS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OrderDescriptionFileAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Orders",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35c16d2a-f25b-4701-9a74-ea1fb7ed6d93"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da40a0c8-cf0f-42f0-b07f-8ac9a0f56638", "AQAAAAIAAYagAAAAEHrA2xgPSXFeVARRMUpVUg5qKh/OnYqjYp9sAPJ8CWDmrxaAjKsW6FkW0oJqU2nH0w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35c16d2a-f25b-4701-9a74-ea1fb7ed6d93"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5884c4c3-789c-4fe4-abd1-0750e9934e1f", "AQAAAAIAAYagAAAAEPQxxtcLsfkjuQgJNd25yeUqO2ynwvLHeDvjsFO7g1mQ++13KNQ32ofL7kGlpRZILg==" });
        }
    }
}
