using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mjenjačnica.Migrations
{
    /// <inheritdoc />
    public partial class promjena4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Iznos",
                table: "Tecaj",
                newName: "IznosU");

            migrationBuilder.AddColumn<double>(
                name: "IznosIz",
                table: "Tecaj",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IznosIz",
                table: "Evidencija",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IznosU",
                table: "Evidencija",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IznosIz",
                table: "Tecaj");

            migrationBuilder.DropColumn(
                name: "IznosIz",
                table: "Evidencija");

            migrationBuilder.DropColumn(
                name: "IznosU",
                table: "Evidencija");

            migrationBuilder.RenameColumn(
                name: "IznosU",
                table: "Tecaj",
                newName: "Iznos");
        }
    }
}
