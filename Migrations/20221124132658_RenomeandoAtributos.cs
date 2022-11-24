using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoAtributos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "Vendedors",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "VendaProduto",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "Produtos",
                newName: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Vendedors",
                newName: "IdVendedor");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "VendaProduto",
                newName: "IdProduto");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produtos",
                newName: "IdProduto");
        }
    }
}
