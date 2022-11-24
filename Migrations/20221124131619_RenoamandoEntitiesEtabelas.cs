using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectFinal.Migrations
{
    /// <inheritdoc />
    public partial class RenoamandoEntitiesEtabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoDto");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "NomeVendedor",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "IdVenda",
                table: "Vendas",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "IdVendedor",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "VendaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Produto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Vendas_Produto",
                        column: x => x.Produto,
                        principalTable: "Vendas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_Produto",
                table: "VendaProduto",
                column: "Produto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendas",
                newName: "IdVenda");

            migrationBuilder.AlterColumn<int>(
                name: "IdVendedor",
                table: "Vendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "Vendas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeVendedor",
                table: "Vendas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProdutoDto",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    VendaIdVenda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoDto", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_ProdutoDto_Vendas_VendaIdVenda",
                        column: x => x.VendaIdVenda,
                        principalTable: "Vendas",
                        principalColumn: "IdVenda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoDto_VendaIdVenda",
                table: "ProdutoDto",
                column: "VendaIdVenda");
        }
    }
}
