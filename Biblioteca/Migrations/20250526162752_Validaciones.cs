using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Validaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibles",
                table: "Libros");

            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Libros",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Libros");

            migrationBuilder.AddColumn<int>(
                name: "Disponibles",
                table: "Libros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
