using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationApp.Migrations
{
    public partial class RemovedCascadeV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarIns_Employees_ExternalEmployeeId",
                table: "CarIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CarIns_Employees_InternalEmployeeId",
                table: "CarIns");

            migrationBuilder.AddForeignKey(
                name: "FK_CarIns_Employees_ExternalEmployeeId",
                table: "CarIns",
                column: "ExternalEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarIns_Employees_InternalEmployeeId",
                table: "CarIns",
                column: "InternalEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarIns_Employees_ExternalEmployeeId",
                table: "CarIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CarIns_Employees_InternalEmployeeId",
                table: "CarIns");

            migrationBuilder.AddForeignKey(
                name: "FK_CarIns_Employees_ExternalEmployeeId",
                table: "CarIns",
                column: "ExternalEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarIns_Employees_InternalEmployeeId",
                table: "CarIns",
                column: "InternalEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
