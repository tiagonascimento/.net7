﻿// <auto-generated />
using System;
using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APICatalogo.Migrations
{
    [DbContext(typeof(ApiCatalogoAppDbContext))]
    [Migration("20230425221030_migracaoInicial")]
    partial class migracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APICatalogo.Model.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("imagemURL")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("APICatalogo.Model.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaIdCategoria")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdProduto");

                    b.HasIndex("CategoriaIdCategoria");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("APICatalogo.Model.Produto", b =>
                {
                    b.HasOne("APICatalogo.Model.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaIdCategoria");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("APICatalogo.Model.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
