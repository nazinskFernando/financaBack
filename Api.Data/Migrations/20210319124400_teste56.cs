using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class teste56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaId",
                table: "Transacao");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Transacao",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaId",
                table: "Transacao",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaId",
                table: "Transacao");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Transacao",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_MesReferencia_MesReferenciaId",
                table: "Transacao",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
