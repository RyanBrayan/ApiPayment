using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossosix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoDtoVenda");

            migrationBuilder.AddColumn<int>(
                name: "VendaIdVenda",
                table: "ProdutoDto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VendaDto",
                columns: table => new
                {
                    IdVendedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaDto", x => x.IdVendedor);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoDtoVendaDto",
                columns: table => new
                {
                    ProdutoDtoIdProduto = table.Column<int>(type: "int", nullable: false),
                    VendaDtosIdVendedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoDtoVendaDto", x => new { x.ProdutoDtoIdProduto, x.VendaDtosIdVendedor });
                    table.ForeignKey(
                        name: "FK_ProdutoDtoVendaDto_ProdutoDto_ProdutoDtoIdProduto",
                        column: x => x.ProdutoDtoIdProduto,
                        principalTable: "ProdutoDto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoDtoVendaDto_VendaDto_VendaDtosIdVendedor",
                        column: x => x.VendaDtosIdVendedor,
                        principalTable: "VendaDto",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoDto_VendaIdVenda",
                table: "ProdutoDto",
                column: "VendaIdVenda");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoDtoVendaDto_VendaDtosIdVendedor",
                table: "ProdutoDtoVendaDto",
                column: "VendaDtosIdVendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoDto_Vendas_VendaIdVenda",
                table: "ProdutoDto",
                column: "VendaIdVenda",
                principalTable: "Vendas",
                principalColumn: "IdVenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoDto_Vendas_VendaIdVenda",
                table: "ProdutoDto");

            migrationBuilder.DropTable(
                name: "ProdutoDtoVendaDto");

            migrationBuilder.DropTable(
                name: "VendaDto");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoDto_VendaIdVenda",
                table: "ProdutoDto");

            migrationBuilder.DropColumn(
                name: "VendaIdVenda",
                table: "ProdutoDto");

            migrationBuilder.CreateTable(
                name: "ProdutoDtoVenda",
                columns: table => new
                {
                    ProdutoDtosIdProduto = table.Column<int>(type: "int", nullable: false),
                    VendasIdVenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoDtoVenda", x => new { x.ProdutoDtosIdProduto, x.VendasIdVenda });
                    table.ForeignKey(
                        name: "FK_ProdutoDtoVenda_ProdutoDto_ProdutoDtosIdProduto",
                        column: x => x.ProdutoDtosIdProduto,
                        principalTable: "ProdutoDto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoDtoVenda_Vendas_VendasIdVenda",
                        column: x => x.VendasIdVenda,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoDtoVenda_VendasIdVenda",
                table: "ProdutoDtoVenda",
                column: "VendasIdVenda");
        }
    }
}
