using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class sorossofdsvbdsfbvasdjo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_ProdutoId",
                table: "VendaProduto",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Produtos_ProdutoId",
                table: "VendaProduto",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Produtos_ProdutoId",
                table: "VendaProduto");

            migrationBuilder.DropIndex(
                name: "IX_VendaProduto_ProdutoId",
                table: "VendaProduto");
        }
    }
}
