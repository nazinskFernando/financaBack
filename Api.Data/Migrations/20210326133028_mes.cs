using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class mes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Saida",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Entrada",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Saida",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "MesReferenciaId",
                table: "Entrada",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_MesReferencia_MesReferenciaId",
                table: "Entrada",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_MesReferencia_MesReferenciaId",
                table: "Saida",
                column: "MesReferenciaId",
                principalTable: "MesReferencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
