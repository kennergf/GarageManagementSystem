using Microsoft.EntityFrameworkCore.Migrations;

namespace GarageManagementSystem.Migrations
{
    public partial class AddedatributeDeletedtoVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Vehicle",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Vehicle");
        }
    }
}
