using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossofive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoDtoVenda_ProdutoDto_ProdutoDtosProdutoId",
                table: "ProdutoDtoVenda");

            migrationBuilder.RenameColumn(
                name: "ProdutoDtosProdutoId",
                table: "ProdutoDtoVenda",
                newName: "ProdutoDtosIdProduto");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "ProdutoDto",
                newName: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoDtoVenda_ProdutoDto_ProdutoDtosIdProduto",
                table: "ProdutoDtoVenda",
                column: "ProdutoDtosIdProduto",
                principalTable: "ProdutoDto",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoDtoVenda_ProdutoDto_ProdutoDtosIdProduto",
                table: "ProdutoDtoVenda");

            migrationBuilder.RenameColumn(
                name: "ProdutoDtosIdProduto",
                table: "ProdutoDtoVenda",
                newName: "ProdutoDtosProdutoId");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "ProdutoDto",
                newName: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoDtoVenda_ProdutoDto_ProdutoDtosProdutoId",
                table: "ProdutoDtoVenda",
                column: "ProdutoDtosProdutoId",
                principalTable: "ProdutoDto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
