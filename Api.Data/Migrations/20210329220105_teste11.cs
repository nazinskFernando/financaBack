using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class teste11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Porcentagam",
                table: "Saida");

            migrationBuilder.AddColumn<double>(
                name: "Porcentagem",
                table: "Saida",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Porcentagem",
                table: "Saida");

            migrationBuilder.AddColumn<double>(
                name: "Porcentagam",
                table: "Saida",
                type: "double",
                nullable: true);
        }
    }
}
