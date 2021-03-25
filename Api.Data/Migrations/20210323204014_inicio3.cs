using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class inicio3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacao");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Saida",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IsFixId",
                table: "Saida",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsFixa",
                table: "Saida",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPago",
                table: "Saida",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "MesReferenciaId",
                table: "Saida",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Saida",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parcelas",
                table: "Saida",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PoupancaId",
                table: "Saida",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Saida",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Entrada",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IsFixId",
                table: "Entrada",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsFixa",
                table: "Entrada",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPago",
                table: "Entrada",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "MesReferenciaId",
                table: "Entrada",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Entrada",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parcelas",
                table: "Entrada",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PoupancaId",
                table: "Entrada",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Entrada",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Saida_MesReferenciaId",
                table: "Saida",
                column: "MesReferenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Saida_PoupancaId",
                table: "Saida",
                column: "PoupancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_MesReferenciaId",
                table: "Entrada",
                column: "MesReferenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_PoupancaId",
                table: "Entrada",
                column: "PoupancaId");

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

            migrationBuilder.DropIndex(
                name: "IX_Saida_MesReferenciaId",
                table: "Saida");

            migrationBuilder.DropIndex(
                name: "IX_Saida_PoupancaId",
                table: "Saida");

            migrationBuilder.DropIndex(
                name: "IX_Entrada_MesReferenciaId",
                table: "Entrada");

            migrationBuilder.DropIndex(
                name: "IX_Entrada_PoupancaId",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "IsFixId",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "IsFixa",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "IsPago",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "MesReferenciaId",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "Parcelas",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "PoupancaId",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "IsFixId",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "IsFixa",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "IsPago",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "MesReferenciaId",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "Parcelas",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "PoupancaId",
                table: "Entrada");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Entrada");

            migrationBuilder.CreateTable(
                name: "Transacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Descricao = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsFixId = table.Column<Guid>(type: "char(36)", nullable: false),
                    IsFixa = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPago = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MesReferenciaId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Parcelas = table.Column<int>(type: "int", nullable: false),
                    PoupancaId = table.Column<Guid>(type: "char(36)", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Valor = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacao_MesReferencia_MesReferenciaId",
                        column: x => x.MesReferenciaId,
                        principalTable: "MesReferencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacao_Poupanca_PoupancaId",
                        column: x => x.PoupancaId,
                        principalTable: "Poupanca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_MesReferenciaId",
                table: "Transacao",
                column: "MesReferenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_PoupancaId",
                table: "Transacao",
                column: "PoupancaId");
        }
    }
}
