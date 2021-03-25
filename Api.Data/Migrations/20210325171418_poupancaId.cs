using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class poupancaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_Poupanca_PoupancaId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_Poupanca_PoupancaId",
                table: "Saida");

            migrationBuilder.AlterColumn<Guid>(
                name: "PoupancaId",
                table: "Saida",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Saida",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IsFixId",
                table: "Saida",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "PoupancaId",
                table: "Entrada",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Entrada",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IsFixId",
                table: "Entrada",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_Poupanca_PoupancaId",
                table: "Entrada",
                column: "PoupancaId",
                principalTable: "Poupanca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_Poupanca_PoupancaId",
                table: "Saida",
                column: "PoupancaId",
                principalTable: "Poupanca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_Poupanca_PoupancaId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_Poupanca_PoupancaId",
                table: "Saida");

            migrationBuilder.AlterColumn<Guid>(
                name: "PoupancaId",
                table: "Saida",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Saida",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IsFixId",
                table: "Saida",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PoupancaId",
                table: "Entrada",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Entrada",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IsFixId",
                table: "Entrada",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_Poupanca_PoupancaId",
                table: "Entrada",
                column: "PoupancaId",
                principalTable: "Poupanca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_Poupanca_PoupancaId",
                table: "Saida",
                column: "PoupancaId",
                principalTable: "Poupanca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
