using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class LivrosAuthores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorLivro_Author_AuthoresAuthorId",
                table: "AuthorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorLivro_Livros_LivrosLivroId",
                table: "AuthorLivro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authores");

            migrationBuilder.RenameColumn(
                name: "LivrosLivroId",
                table: "AuthorLivro",
                newName: "livrosLivroId");

            migrationBuilder.RenameColumn(
                name: "AuthoresAuthorId",
                table: "AuthorLivro",
                newName: "AuthorsAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorLivro_LivrosLivroId",
                table: "AuthorLivro",
                newName: "IX_AuthorLivro_livrosLivroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authores",
                table: "Authores",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorLivro_Authores_AuthorsAuthorId",
                table: "AuthorLivro",
                column: "AuthorsAuthorId",
                principalTable: "Authores",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorLivro_Livros_livrosLivroId",
                table: "AuthorLivro",
                column: "livrosLivroId",
                principalTable: "Livros",
                principalColumn: "LivroId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorLivro_Authores_AuthorsAuthorId",
                table: "AuthorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorLivro_Livros_livrosLivroId",
                table: "AuthorLivro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authores",
                table: "Authores");

            migrationBuilder.RenameTable(
                name: "Authores",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "livrosLivroId",
                table: "AuthorLivro",
                newName: "LivrosLivroId");

            migrationBuilder.RenameColumn(
                name: "AuthorsAuthorId",
                table: "AuthorLivro",
                newName: "AuthoresAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorLivro_livrosLivroId",
                table: "AuthorLivro",
                newName: "IX_AuthorLivro_LivrosLivroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorLivro_Author_AuthoresAuthorId",
                table: "AuthorLivro",
                column: "AuthoresAuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorLivro_Livros_LivrosLivroId",
                table: "AuthorLivro",
                column: "LivrosLivroId",
                principalTable: "Livros",
                principalColumn: "LivroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
