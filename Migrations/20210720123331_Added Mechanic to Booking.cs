using Microsoft.EntityFrameworkCore.Migrations;

namespace GarageManagementSystem.Migrations
{
    public partial class AddedMechanictoBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MechanicId",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_MechanicId",
                table: "Booking",
                column: "MechanicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_MechanicId",
                table: "Booking",
                column: "MechanicId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_MechanicId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_MechanicId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "MechanicId",
                table: "Booking");
        }
    }
}
