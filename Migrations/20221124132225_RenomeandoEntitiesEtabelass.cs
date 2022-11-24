using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoEntitiesEtabelass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_Produto",
                table: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "Produto",
                table: "VendaProduto",
                newName: "Teste");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_Produto",
                table: "VendaProduto",
                newName: "IX_VendaProduto_Teste");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_Teste",
                table: "VendaProduto",
                column: "Teste",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_Teste",
                table: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "Teste",
                table: "VendaProduto",
                newName: "Produto");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_Teste",
                table: "VendaProduto",
                newName: "IX_VendaProduto_Produto");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_Produto",
                table: "VendaProduto",
                column: "Produto",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }
    }
}
