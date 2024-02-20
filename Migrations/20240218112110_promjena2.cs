using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mjenjačnica.Migrations
{
    /// <inheritdoc />
    public partial class promjena2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Iznos",
                table: "Tecaj",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iznos",
                table: "Tecaj");
        }
    }
}
