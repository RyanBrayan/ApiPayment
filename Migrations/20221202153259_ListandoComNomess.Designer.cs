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
    [Migration("20221202153259_ListandoComNomess")]
    partial class ListandoComNomess
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projectFinal.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("projectFinal.Entities.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendaId"));

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("VendaId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("projectFinal.Entities.VendaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("VendaProdutos");
                });

            modelBuilder.Entity("projectFinal.Entities.Vendedor", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendedorId"));

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendedorId");

                    b.ToTable("Vendedors");
                });

            modelBuilder.Entity("projectFinal.Entities.VendaProduto", b =>
                {
                    b.HasOne("projectFinal.Entities.Produto", null)
                        .WithMany("VendaProdutos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projectFinal.Entities.Venda", null)
                        .WithMany("VendaProdutos")
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("projectFinal.Entities.Produto", b =>
                {
                    b.Navigation("VendaProdutos");
                });

            modelBuilder.Entity("projectFinal.Entities.Venda", b =>
                {
                    b.Navigation("VendaProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}
