using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossotwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idProduto",
                table: "Vendas");

            migrationBuilder.AlterColumn<int>(
                name: "IdVendedor",
                table: "Vendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "produtoDto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    VendaIdVenda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtoDto", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_produtoDto_Vendas_VendaIdVenda",
                        column: x => x.VendaIdVenda,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtoDto_VendaIdVenda",
                table: "produtoDto",
                column: "VendaIdVenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtoDto");

            migrationBuilder.AlterColumn<int>(
                name: "IdVendedor",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idProduto",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
