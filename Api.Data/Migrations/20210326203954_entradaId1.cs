using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class entradaId1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saida_Entrada_EntradaId",
                table: "Saida");

            migrationBuilder.DropIndex(
                name: "IX_Saida_EntradaId",
                table: "Saida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
