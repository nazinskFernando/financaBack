using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class teste55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaEntityId",
                table: "Transacao");

            migrationBuilder.DropIndex(
                name: "IX_Transacao_MesReferenciaEntityId",
                table: "Transacao");

            migrationBuilder.DropColumn(
                name: "MesReferenciaEntityId",
                table: "Transacao");

            migrationBuilder.AddColumn<Guid>(
                name: "MesReferenciaId",
                table: "Transacao",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_MesReferenciaId",
                table: "Transacao",
                column: "MesReferenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaId",
                table: "Transacao",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaId",
                table: "Transacao");

            migrationBuilder.DropIndex(
                name: "IX_Transacao_MesReferenciaId",
                table: "Transacao");

            migrationBuilder.DropColumn(
                name: "MesReferenciaId",
                table: "Transacao");

            migrationBuilder.AddColumn<Guid>(
                name: "MesReferenciaEntityId",
                table: "Transacao",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_MesReferenciaEntityId",
                table: "Transacao",
                column: "MesReferenciaEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaEntityId",
                table: "Transacao",
                column: "MesReferenciaEntityId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
