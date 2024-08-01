using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Mangas.Migrations
{
    /// <inheritdoc />
    public partial class MangasPorCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconCSS",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconCSS",
                value: "oi oi-aperture");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconCSS",
                value: "oi oi-fire");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconCSS",
                value: "oi oi-cloudy");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "IconCSS",
                value: "oi oi-layers");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "IconCSS",
                value: "oi oi-tablet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconCSS",
                table: "Categorias");
        }
    }
}
