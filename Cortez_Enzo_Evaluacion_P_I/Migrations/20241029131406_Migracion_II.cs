using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cortez_Enzo_Evaluacion_P_I.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_II : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECortez_Celular_CelularId",
                table: "ECortez");

            migrationBuilder.AlterColumn<double>(
                name: "Mesada",
                table: "ECortez",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "Estudiante",
                table: "ECortez",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Cummpleaños",
                table: "ECortez",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CelularId",
                table: "ECortez",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Celular",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_ECortez_Celular_CelularId",
                table: "ECortez",
                column: "CelularId",
                principalTable: "Celular",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECortez_Celular_CelularId",
                table: "ECortez");

            migrationBuilder.AlterColumn<decimal>(
                name: "Mesada",
                table: "ECortez",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<bool>(
                name: "Estudiante",
                table: "ECortez",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Cummpleaños",
                table: "ECortez",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CelularId",
                table: "ECortez",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Celular",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_ECortez_Celular_CelularId",
                table: "ECortez",
                column: "CelularId",
                principalTable: "Celular",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
