using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoEntitiesEtabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_Teste",
                table: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "Teste",
                table: "VendaProduto",
                newName: "IdVenda");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_Teste",
                table: "VendaProduto",
                newName: "IX_VendaProduto_IdVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_IdVenda",
                table: "VendaProduto",
                column: "IdVenda",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_IdVenda",
                table: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "IdVenda",
                table: "VendaProduto",
                newName: "Teste");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_IdVenda",
                table: "VendaProduto",
                newName: "IX_VendaProduto_Teste");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_Teste",
                table: "VendaProduto",
                column: "Teste",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }
    }
}
