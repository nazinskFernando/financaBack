using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoOperacao",
                table: "Transacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoOperacaoEntrada",
                table: "Transacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoOperacaoSaida",
                table: "Transacao",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoOperacao",
                table: "Transacao");

            migrationBuilder.DropColumn(
                name: "TipoOperacaoEntrada",
                table: "Transacao");

            migrationBuilder.DropColumn(
                name: "TipoOperacaoSaida",
                table: "Transacao");
        }
    }
}
