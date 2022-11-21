using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sorossocorreto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.AddColumn<int>(
                name: "idProduto",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idProduto",
                table: "Vendas");

            migrationBuilder.CreateTable(
                name: "VendaProduto",
                columns: table => new
                {
                    IdVendaProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    ProdutoDto = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProduto", x => x.IdVendaProduto);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Vendas_ProdutoDto",
                        column: x => x.ProdutoDto,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_ProdutoDto",
                table: "VendaProduto",
                column: "ProdutoDto");
        }
    }
}
