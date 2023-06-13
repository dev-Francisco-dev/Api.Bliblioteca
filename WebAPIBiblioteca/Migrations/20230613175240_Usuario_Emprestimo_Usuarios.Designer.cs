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
    [Migration("20230613175240_Usuario_Emprestimo_Usuarios")]
    partial class Usuario_Emprestimo_Usuarios
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

            modelBuilder.Entity("Domain.Models.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmprestimoId"));

                    b.Property<DateTimeOffset>("DataEmprestimo")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DataEntregaEmprestimo")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("EmprestimoId");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimos");
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

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
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

            modelBuilder.Entity("Domain.Models.Emprestimo", b =>
                {
                    b.HasOne("Domain.Models.Livro", "Livro")
                        .WithMany("Emprestimos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Usuario", "Usuario")
                        .WithMany("Emprestimos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.HasOne("Domain.Models.Usuario", null)
                        .WithMany("Livros")
                        .HasForeignKey("UsuarioId");
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

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Navigation("Emprestimos");

                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
