using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class entradaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EntradaId",
                table: "Saida",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Saida_EntradaId",
                table: "Saida",
                column: "EntradaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_Entrada_EntradaId",
                table: "Saida",
                column: "EntradaId",
                principalTable: "Entrada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saida_Entrada_EntradaId",
                table: "Saida");

            migrationBuilder.DropIndex(
                name: "IX_Saida_EntradaId",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "EntradaId",
                table: "Saida");
        }
    }
}
