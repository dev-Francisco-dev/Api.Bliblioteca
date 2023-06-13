﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIBiblioteca.Data;

#nullable disable

namespace WebAPIBiblioteca.Migrations
{
    [DbContext(typeof(DbContextBiblioteca))]
    [Migration("20230613173748_Livros_Editora")]
    partial class Livros_Editora
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorLivro", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("livrosLivroId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "livrosLivroId");

                    b.HasIndex("livrosLivroId");

                    b.ToTable("AuthorLivro");
                });

            modelBuilder.Entity("CategoriaLivro", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("LivrosLivroId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "LivrosLivroId");

                    b.HasIndex("LivrosLivroId");

                    b.ToTable("CategoriaLivro");
                });

            modelBuilder.Entity("Domain.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authores");
                });

            modelBuilder.Entity("Domain.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Domain.Models.Editora", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EditoraId"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EditoraId");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivroId"));

                    b.Property<DateTimeOffset>("AnoDePublicacao")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LivroId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("EditoraLivro", b =>
                {
                    b.Property<int>("EditorasEditoraId")
                        .HasColumnType("int");

                    b.Property<int>("livrosLivroId")
                        .HasColumnType("int");

                    b.HasKey("EditorasEditoraId", "livrosLivroId");

                    b.HasIndex("livrosLivroId");

                    b.ToTable("EditoraLivro");
                });

            modelBuilder.Entity("AuthorLivro", b =>
                {
                    b.HasOne("Domain.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Livro", null)
                        .WithMany()
                        .HasForeignKey("livrosLivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoriaLivro", b =>
                {
                    b.HasOne("Domain.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Livro", null)
                        .WithMany()
                        .HasForeignKey("LivrosLivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EditoraLivro", b =>
                {
                    b.HasOne("Domain.Models.Editora", null)
                        .WithMany()
                        .HasForeignKey("EditorasEditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Livro", null)
                        .WithMany()
                        .HasForeignKey("livrosLivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
