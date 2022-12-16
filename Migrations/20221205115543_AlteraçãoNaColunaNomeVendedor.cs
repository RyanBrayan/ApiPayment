using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class AlteraçãoNaColunaNomeVendedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProdutos_Vendas_VendaId",
                table: "VendaProdutos");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Vendedors",
                newName: "NomeVendedor");

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "VendaProdutos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProdutos_Vendas_VendaId",
                table: "VendaProdutos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProdutos_Vendas_VendaId",
                table: "VendaProdutos");

            migrationBuilder.RenameColumn(
                name: "NomeVendedor",
                table: "Vendedors",
                newName: "Nome");

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "VendaProdutos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProdutos_Vendas_VendaId",
                table: "VendaProdutos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }
    }
}
