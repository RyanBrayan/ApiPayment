using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossothree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtoDto_Vendas_VendaIdVenda",
                table: "produtoDto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtoDto",
                table: "produtoDto");

            migrationBuilder.RenameTable(
                name: "produtoDto",
                newName: "produtoDtos");

            migrationBuilder.RenameIndex(
                name: "IX_produtoDto_VendaIdVenda",
                table: "produtoDtos",
                newName: "IX_produtoDtos_VendaIdVenda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtoDtos",
                table: "produtoDtos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_produtoDtos_Vendas_VendaIdVenda",
                table: "produtoDtos",
                column: "VendaIdVenda",
                principalTable: "Vendas",
                principalColumn: "IdVenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtoDtos_Vendas_VendaIdVenda",
                table: "produtoDtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtoDtos",
                table: "produtoDtos");

            migrationBuilder.RenameTable(
                name: "produtoDtos",
                newName: "produtoDto");

            migrationBuilder.RenameIndex(
                name: "IX_produtoDtos_VendaIdVenda",
                table: "produtoDto",
                newName: "IX_produtoDto_VendaIdVenda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtoDto",
                table: "produtoDto",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_produtoDto_Vendas_VendaIdVenda",
                table: "produtoDto",
                column: "VendaIdVenda",
                principalTable: "Vendas",
                principalColumn: "IdVenda");
        }
    }
}
