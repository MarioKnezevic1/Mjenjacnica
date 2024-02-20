using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mjenjačnica.Migrations
{
    /// <inheritdoc />
    public partial class promjena5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IznosIz",
                table: "Tecaj");

            migrationBuilder.DropColumn(
                name: "IznosU",
                table: "Tecaj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "IznosIz",
                table: "Tecaj",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IznosU",
                table: "Tecaj",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
