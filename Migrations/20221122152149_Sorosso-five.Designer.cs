﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectFinal.Context;

#nullable disable

namespace projectFinal.Migrations
{
    [DbContext(typeof(EccomerceContext))]
    [Migration("20221122152149_Sorosso-five")]
    partial class Sorossofive
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProdutoDtoVenda", b =>
                {
                    b.Property<int>("ProdutoDtosIdProduto")
                        .HasColumnType("int");

                    b.Property<int>("VendasIdVenda")
                        .HasColumnType("int");

                    b.HasKey("ProdutoDtosIdProduto", "VendasIdVenda");

                    b.HasIndex("VendasIdVenda");

                    b.ToTable("ProdutoDtoVenda");
                });

            modelBuilder.Entity("projectFinal.DTO.ProdutoDto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"));

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("IdProduto");

                    b.ToTable("ProdutoDto");
                });

            modelBuilder.Entity("projectFinal.Entities.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"));

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("projectFinal.Entities.Venda", b =>
                {
                    b.Property<int>("IdVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenda"));

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdVenda");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("projectFinal.Entities.Vendedor", b =>
                {
                    b.Property<int>("IdVendedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVendedor"));

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVendedor");

                    b.ToTable("Vendedors");
                });

            modelBuilder.Entity("ProdutoDtoVenda", b =>
                {
                    b.HasOne("projectFinal.DTO.ProdutoDto", null)
                        .WithMany()
                        .HasForeignKey("ProdutoDtosIdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projectFinal.Entities.Venda", null)
                        .WithMany()
                        .HasForeignKey("VendasIdVenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
