using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediClinic.Domain.Migrations
{
    public partial class sjdsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_WorkTimes_WorkTimeId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "WorkTimeWeekDayRelations");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_WorkTimeId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "WorkTimeId",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "WeekDay",
                table: "WorkTimes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DoctorWorkTimeRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkTimeId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorWorkTimeRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorWorkTimeRelations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorWorkTimeRelations_WorkTimes_WorkTimeId",
                        column: x => x.WorkTimeId,
                        principalTable: "WorkTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorWorkTimeRelations_DoctorId",
                table: "DoctorWorkTimeRelations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorWorkTimeRelations_WorkTimeId",
                table: "DoctorWorkTimeRelations",
                column: "WorkTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorWorkTimeRelations");

            migrationBuilder.DropColumn(
                name: "WeekDay",
                table: "WorkTimes");

            migrationBuilder.AddColumn<int>(
                name: "WorkTimeId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkTimeWeekDayRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    WorkTimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTimeWeekDayRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTimeWeekDayRelations_WorkTimes_WorkTimeId",
                        column: x => x.WorkTimeId,
                        principalTable: "WorkTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_WorkTimeId",
                table: "Doctors",
                column: "WorkTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimeWeekDayRelations_WorkTimeId",
                table: "WorkTimeWeekDayRelations",
                column: "WorkTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_WorkTimes_WorkTimeId",
                table: "Doctors",
                column: "WorkTimeId",
                principalTable: "WorkTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
