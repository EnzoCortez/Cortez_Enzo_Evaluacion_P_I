using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cortez_Enzo_Evaluacion_P_I.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_I : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Año = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ECortez",
                columns: table => new
                {
                    Cedula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Mesada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estudiante = table.Column<bool>(type: "bit", nullable: true),
                    Cummpleaños = table.Column<DateOnly>(type: "date", nullable: true),
                    CelularId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECortez", x => x.Cedula);
                    table.ForeignKey(
                        name: "FK_ECortez_Celular_CelularId",
                        column: x => x.CelularId,
                        principalTable: "Celular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ECortez_CelularId",
                table: "ECortez",
                column: "CelularId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECortez");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
