using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediClinic.Domain.Migrations
{
    public partial class ROle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "Membership",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Membership",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedByUserId",
                schema: "Membership",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                schema: "Membership",
                table: "Roles",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "Membership",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Membership",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                schema: "Membership",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                schema: "Membership",
                table: "Roles");
        }
    }
}
