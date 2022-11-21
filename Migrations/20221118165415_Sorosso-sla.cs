using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossosla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Vendas_ProdutoDto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ProdutoDto",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ProdutoDto",
                table: "Produtos");

            migrationBuilder.CreateTable(
                name: "VendaProduto",
                columns: table => new
                {
                    IdVendaProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ProdutoDto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProduto", x => x.IdVendaProduto);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Vendas_ProdutoDto",
                        column: x => x.ProdutoDto,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_ProdutoDto",
                table: "VendaProduto",
                column: "ProdutoDto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoDto",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProdutoDto",
                table: "Produtos",
                column: "ProdutoDto");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Vendas_ProdutoDto",
                table: "Produtos",
                column: "ProdutoDto",
                principalTable: "Vendas",
                principalColumn: "IdVenda");
        }
    }
}
