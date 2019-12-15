using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabYago.Migrations
{
    public partial class _0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placar_Jogador_JogId",
                table: "Placar");

            migrationBuilder.DropIndex(
                name: "IX_Placar_JogId",
                table: "Placar");

            migrationBuilder.DropColumn(
                name: "JogId",
                table: "Placar");

            migrationBuilder.AddColumn<string>(
                name: "JogadorNome",
                table: "Placar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JogadorNome",
                table: "Placar");

            migrationBuilder.AddColumn<int>(
                name: "JogId",
                table: "Placar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Placar_JogId",
                table: "Placar",
                column: "JogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Placar_Jogador_JogId",
                table: "Placar",
                column: "JogId",
                principalTable: "Jogador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
