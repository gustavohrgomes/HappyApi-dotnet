using Microsoft.EntityFrameworkCore.Migrations;

namespace Happy.Migrations
{
    public partial class ChangeOrphanageLatLngProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Orphanages",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Orphanages",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Orphanages",
                type: "double",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Orphanages",
                type: "double",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
