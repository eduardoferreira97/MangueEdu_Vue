using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Manguedu.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaConfiguracoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EscolaId",
                table: "AspNetUsers",
                column: "EscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Escola_EscolaId",
                table: "AspNetUsers",
                column: "EscolaId",
                principalTable: "Escola",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Escola_EscolaId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Escola");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EscolaId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AspNetUsers");
        }
    }
}
