﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossoeigth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoVenda");

            migrationBuilder.CreateTable(
                name: "ProdutoDto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    VendaIdVenda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoDto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_ProdutoDto_Vendas_VendaIdVenda",
                        column: x => x.VendaIdVenda,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoDto_VendaIdVenda",
                table: "ProdutoDto",
                column: "VendaIdVenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoDto");

            migrationBuilder.CreateTable(
                name: "ProdutoVenda",
                columns: table => new
                {
                    ProdutosIdProduto = table.Column<int>(type: "int", nullable: false),
                    VendasIdVenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoVenda", x => new { x.ProdutosIdProduto, x.VendasIdVenda });
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Produtos_ProdutosIdProduto",
                        column: x => x.ProdutosIdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Vendas_VendasIdVenda",
                        column: x => x.VendasIdVenda,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoVenda_VendasIdVenda",
                table: "ProdutoVenda",
                column: "VendasIdVenda");
        }
    }
}
