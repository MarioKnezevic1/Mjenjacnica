using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mjenjačnica.Migrations
{
    /// <inheritdoc />
    public partial class Dodavanje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evidencija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonvertirajU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KonvertirajIz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tecaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidencija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonvertirajU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KonvertirajIz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tecaj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecaj", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evidencija");

            migrationBuilder.DropTable(
                name: "Tecaj");
        }
    }
}
