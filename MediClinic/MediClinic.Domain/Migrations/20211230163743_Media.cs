using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediClinic.Domain.Migrations
{
    public partial class Media : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorSocialMediaRelations");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "SocialMedia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_DoctorId",
                table: "SocialMedia",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedia_Doctors_DoctorId",
                table: "SocialMedia",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedia_Doctors_DoctorId",
                table: "SocialMedia");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedia_DoctorId",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "SocialMedia");

            migrationBuilder.CreateTable(
                name: "DoctorSocialMediaRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSocialMediaRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorSocialMediaRelations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorSocialMediaRelations_SocialMedia_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSocialMediaRelations_DoctorId",
                table: "DoctorSocialMediaRelations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSocialMediaRelations_SocialMediaId",
                table: "DoctorSocialMediaRelations",
                column: "SocialMediaId");
        }
    }
}
