﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogaresTeatrais.Data.Migrations
{
    public partial class TabelaDesempenho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desempenho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JogarId = table.Column<int>(type: "INTEGER", nullable: false),
                    Audiencia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desempenho", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Desempenho",
                columns: new[] { "Id", "Audiencia", "JogarId" },
                values: new object[] { 1, 55, 1 });

            migrationBuilder.InsertData(
                table: "Desempenho",
                columns: new[] { "Id", "Audiencia", "JogarId" },
                values: new object[] { 3, 35, 2 });

            migrationBuilder.InsertData(
                table: "Desempenho",
                columns: new[] { "Id", "Audiencia", "JogarId" },
                values: new object[] { 4, 40, 3 });

            migrationBuilder.InsertData(
                table: "Jogar",
                columns: new[] { "Id", "Linhas", "Nome", "Tipo" },
                values: new object[] { 1, 4024, "Hamlet", "tragedy" });

            migrationBuilder.InsertData(
                table: "Jogar",
                columns: new[] { "Id", "Linhas", "Nome", "Tipo" },
                values: new object[] { 2, 2670, "As You Like It", "comedy" });

            migrationBuilder.InsertData(
                table: "Jogar",
                columns: new[] { "Id", "Linhas", "Nome", "Tipo" },
                values: new object[] { 3, 3560, "Othello", "tragedy" });

            migrationBuilder.InsertData(
                table: "Jogar",
                columns: new[] { "Id", "Linhas", "Nome", "Tipo" },
                values: new object[] { 4, 3227, "Henry V", "history" });

            migrationBuilder.InsertData(
                table: "Jogar",
                columns: new[] { "Id", "Linhas", "Nome", "Tipo" },
                values: new object[] { 5, 3560, "John", "history" });

            migrationBuilder.InsertData(
                table: "Jogar",
                columns: new[] { "Id", "Linhas", "Nome", "Tipo" },
                values: new object[] { 6, 3718, "Richard-III", "history" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desempenho");

            migrationBuilder.DeleteData(
                table: "Jogar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jogar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jogar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jogar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jogar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jogar",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
