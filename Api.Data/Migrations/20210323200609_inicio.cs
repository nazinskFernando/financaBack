using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MesReferencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Mes = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesReferencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planejamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    Parcelas = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planejamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poupanca",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poupanca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanejamentoParcelado",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    ParcelaTotal = table.Column<int>(nullable: false),
                    ParcelaAtual = table.Column<int>(nullable: false),
                    MesReferenciaId = table.Column<Guid>(nullable: false),
                    PlanejamentoId = table.Column<Guid>(nullable: false),
                    PlanejamentosId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanejamentoParcelado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanejamentoParcelado_MesReferencia_MesReferenciaId",
                        column: x => x.MesReferenciaId,
                        principalTable: "MesReferencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanejamentoParcelado_Planejamentos_PlanejamentosId",
                        column: x => x.PlanejamentosId,
                        principalTable: "Planejamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Parcelas = table.Column<int>(nullable: false),
                    IsPago = table.Column<bool>(nullable: false),
                    IsFixa = table.Column<bool>(nullable: false),
                    IsFixId = table.Column<Guid>(nullable: false),
                    MesReferenciaId = table.Column<Guid>(nullable: false),
                    PoupancaId = table.Column<Guid>(nullable: false)
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
                name: "IX_PlanejamentoParcelado_MesReferenciaId",
                table: "PlanejamentoParcelado",
                column: "MesReferenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanejamentoParcelado_PlanejamentosId",
                table: "PlanejamentoParcelado",
                column: "PlanejamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_MesReferenciaId",
                table: "Transacao",
                column: "MesReferenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_PoupancaId",
                table: "Transacao",
                column: "PoupancaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanejamentoParcelado");

            migrationBuilder.DropTable(
                name: "Transacao");

            migrationBuilder.DropTable(
                name: "Planejamentos");

            migrationBuilder.DropTable(
                name: "MesReferencia");

            migrationBuilder.DropTable(
                name: "Poupanca");
        }
    }
}
