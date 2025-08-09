using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesMostenAPI.Migrations
{
    /// <inheritdoc />
    public partial class listaDeGeneros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genero",
                value: new List<string> { "Terror", "Drama", "Suspense" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genero",
                value: new List<string> { "Aventura", "Fantasia" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Genero",
                value: new List<string> { "Ação", "Aventura" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Genero",
                value: new List<string> { "Drama", "Crime" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Genero",
                value: new List<string> { "Ação", "Crime" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genero",
                value: new List<string> { "Terror", "Drama", "Suspense" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genero",
                value: new List<string> { "Aventura", "Fantasia" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Genero",
                value: new List<string> { "Ação", "Aventura" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Genero",
                value: new List<string> { "Drama", "Crime" });

            migrationBuilder.UpdateData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Genero",
                value: new List<string> { "Ação", "Crime" });
        }
    }
}
