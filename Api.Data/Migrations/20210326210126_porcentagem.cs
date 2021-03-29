using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class porcentagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Porcentagam",
                table: "Saida",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Porcentagam",
                table: "Saida");
        }
    }
}
