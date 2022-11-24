using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_IdVenda",
                table: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "IdVenda",
                table: "VendaProduto",
                newName: "VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_IdVenda",
                table: "VendaProduto",
                newName: "IX_VendaProduto_VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_VendaId",
                table: "VendaProduto",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_VendaId",
                table: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "VendaId",
                table: "VendaProduto",
                newName: "IdVenda");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_VendaId",
                table: "VendaProduto",
                newName: "IX_VendaProduto_IdVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_IdVenda",
                table: "VendaProduto",
                column: "IdVenda",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }
    }
}
