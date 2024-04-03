using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DangKi.Migrations
{
    /// <inheritdoc />
    public partial class initdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Daily",
                table: "ScheduleDetails",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "timeEnd",
                table: "ScheduleDetails",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "timeStart",
                table: "ScheduleDetails",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Daily",
                table: "ScheduleDetails");

            migrationBuilder.DropColumn(
                name: "timeEnd",
                table: "ScheduleDetails");

            migrationBuilder.DropColumn(
                name: "timeStart",
                table: "ScheduleDetails");
        }
    }
}
