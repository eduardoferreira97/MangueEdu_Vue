using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Manguedu.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaResposta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resposta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EscolaId = table.Column<int>(type: "integer", nullable: false),
                    AlunoId = table.Column<int>(type: "integer", nullable: false),
                    Modulo = table.Column<int>(type: "integer", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PrimeiraPergunta = table.Column<string>(type: "text", nullable: false),
                    SegundaPergunta = table.Column<string>(type: "text", nullable: false),
                    TerceiraPergunta = table.Column<string>(type: "text", nullable: false),
                    QuartaPergunta = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resposta_AlunoHistorico_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "AlunoHistorico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resposta_Escola_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resposta_AlunoId",
                table: "Resposta",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Resposta_EscolaId",
                table: "Resposta",
                column: "EscolaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resposta");
        }
    }
}
