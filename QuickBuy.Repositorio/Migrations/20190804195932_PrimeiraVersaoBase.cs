using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class PrimeiraVersaoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formaPagamento",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaPagamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 50, nullable: false),
                    descricao = table.Column<string>(maxLength: 500, nullable: false),
                    preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    senha = table.Column<string>(maxLength: 400, nullable: false),
                    nome = table.Column<string>(maxLength: 50, nullable: false),
                    sobreNome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataPedido = table.Column<DateTime>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false),
                    dataPrecisaoEntrega = table.Column<DateTime>(nullable: false),
                    CEP = table.Column<string>(maxLength: 10, nullable: false),
                    estado = table.Column<string>(maxLength: 100, nullable: false),
                    cidade = table.Column<string>(maxLength: 100, nullable: false),
                    enderecoCompleto = table.Column<string>(maxLength: 100, nullable: false),
                    numeroEndereco = table.Column<int>(nullable: false),
                    formaPagamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_pedidos_formaPagamento_formaPagamentoId",
                        column: x => x.formaPagamentoId,
                        principalTable: "formaPagamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itensPedidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    produtoId = table.Column<int>(nullable: false),
                    quantidade = table.Column<int>(nullable: false),
                    Pedidoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itensPedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_itensPedidos_pedidos_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itensPedidos_Pedidoid",
                table: "itensPedidos",
                column: "Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_formaPagamentoId",
                table: "pedidos",
                column: "formaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_usuarioId",
                table: "pedidos",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itensPedidos");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "formaPagamento");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
