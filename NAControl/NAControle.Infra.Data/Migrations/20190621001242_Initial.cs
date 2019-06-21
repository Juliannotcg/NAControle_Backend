using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NAControle.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Logradouro = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Lote = table.Column<int>(type: "INT", nullable: false),
                    Rua = table.Column<int>(type: "INT", nullable: false),
                    Quadra = table.Column<int>(type: "INT", nullable: false),
                    Cep = table.Column<int>(type: "INT", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Uf = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Longitude = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnderecoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupo_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servidor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    SobreNome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    EnderecoId = table.Column<Guid>(nullable: true),
                    GrupoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servidor_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servidor_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reuniao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Dia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    HoraFim = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Aberta = table.Column<bool>(type: "BIT", nullable: false),
                    Ativa = table.Column<bool>(type: "BIT", nullable: false),
                    SecretarioId = table.Column<Guid>(nullable: true),
                    GrupoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reuniao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reuniao_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reuniao_Servidor_SecretarioId",
                        column: x => x.SecretarioId,
                        principalTable: "Servidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_EnderecoId",
                table: "Grupo",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_GrupoId",
                table: "Reuniao",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_SecretarioId",
                table: "Reuniao",
                column: "SecretarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Servidor_EnderecoId",
                table: "Servidor",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Servidor_GrupoId",
                table: "Servidor",
                column: "GrupoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reuniao");

            migrationBuilder.DropTable(
                name: "Servidor");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
