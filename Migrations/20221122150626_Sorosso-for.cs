using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossofor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtoDtos_Vendas_VendaIdVenda",
                table: "produtoDtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtoDtos",
                table: "produtoDtos");

            migrationBuilder.DropIndex(
                name: "IX_produtoDtos_VendaIdVenda",
                table: "produtoDtos");

            migrationBuilder.DropColumn(
                name: "VendaIdVenda",
                table: "produtoDtos");

            migrationBuilder.RenameTable(
                name: "produtoDtos",
                newName: "ProdutoDto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutoDto",
                table: "ProdutoDto",
                column: "ProdutoId");

            migrationBuilder.CreateTable(
                name: "ProdutoDtoVenda",
                columns: table => new
                {
                    ProdutoDtosProdutoId = table.Column<int>(type: "int", nullable: false),
                    VendasIdVenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoDtoVenda", x => new { x.ProdutoDtosProdutoId, x.VendasIdVenda });
                    table.ForeignKey(
                        name: "FK_ProdutoDtoVenda_ProdutoDto_ProdutoDtosProdutoId",
                        column: x => x.ProdutoDtosProdutoId,
                        principalTable: "ProdutoDto",
                        principalColumn: "ProdutoId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoDtoVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutoDto",
                table: "ProdutoDto");

            migrationBuilder.RenameTable(
                name: "ProdutoDto",
                newName: "produtoDtos");

            migrationBuilder.AddColumn<int>(
                name: "VendaIdVenda",
                table: "produtoDtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtoDtos",
                table: "produtoDtos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produtoDtos_VendaIdVenda",
                table: "produtoDtos",
                column: "VendaIdVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_produtoDtos_Vendas_VendaIdVenda",
                table: "produtoDtos",
                column: "VendaIdVenda",
                principalTable: "Vendas",
                principalColumn: "IdVenda");
        }
    }
}
