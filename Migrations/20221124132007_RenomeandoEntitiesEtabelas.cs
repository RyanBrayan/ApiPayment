using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoEntitiesEtabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "Vendas",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendas",
                newName: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Vendas",
                newName: "IdVendedor");

            migrationBuilder.RenameColumn(
                name: "VendaId",
                table: "Vendas",
                newName: "Id");
        }
    }
}
