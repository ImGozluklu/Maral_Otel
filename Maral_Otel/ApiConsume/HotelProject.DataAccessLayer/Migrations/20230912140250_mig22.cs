using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
            name: "RoomNumber",
            table: "Rooms",
            type: "nvarchar(max)",
            nullable: true, // Make this column nullable
            oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomCoverImage",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true, // Make this column nullable
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Rooms",
                type: "int",
                nullable: true, // Make this column nullable
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true, // Make this column nullable
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BedCount",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true, // Make this column nullable
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BathCount",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true, // Make this column nullable
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Wifi",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true, // Make this column nullable
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true, // Make this column nullable
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
