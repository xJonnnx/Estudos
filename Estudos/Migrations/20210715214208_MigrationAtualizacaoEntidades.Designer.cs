﻿// <auto-generated />
using System;
using Estudos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estudos.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20210715214208_MigrationAtualizacaoEntidades")]
    partial class MigrationAtualizacaoEntidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estudos.Entidades+Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Estudos.Entidades+Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("NomeItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecoItem")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Estudos.Entidades+Produto", b =>
                {
                    b.HasOne("Estudos.Entidades+Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaID");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Estudos.Entidades+Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
