using Microsoft.EntityFrameworkCore.Migrations;

namespace MediClinic.Domain.Migrations
{
    public partial class speciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "Doctors",
                newName: "Speciality");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "Doctors",
                newName: "Specialty");
        }
    }
}
