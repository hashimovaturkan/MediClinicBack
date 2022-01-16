using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediClinic.Domain.Migrations
{
    public partial class uodateRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "Membership",
                table: "RoleClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Membership",
                table: "RoleClaims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedByUserId",
                schema: "Membership",
                table: "RoleClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                schema: "Membership",
                table: "RoleClaims",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "Membership",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Membership",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                schema: "Membership",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                schema: "Membership",
                table: "RoleClaims");
        }
    }
}
