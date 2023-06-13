using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Emprestimo_Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Livros_LivroId",
                table: "Comentario");

            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Usuarios_UsuarioId",
                table: "Comentario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario");

            migrationBuilder.RenameTable(
                name: "Comentario",
                newName: "comentarios");

            migrationBuilder.RenameIndex(
                name: "IX_Comentario_UsuarioId",
                table: "comentarios",
                newName: "IX_comentarios_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Comentario_LivroId",
                table: "comentarios",
                newName: "IX_comentarios_LivroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comentarios",
                table: "comentarios",
                column: "ComentarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_Livros_LivroId",
                table: "comentarios",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "LivroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_Usuarios_UsuarioId",
                table: "comentarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comentarios_Livros_LivroId",
                table: "comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_comentarios_Usuarios_UsuarioId",
                table: "comentarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comentarios",
                table: "comentarios");

            migrationBuilder.RenameTable(
                name: "comentarios",
                newName: "Comentario");

            migrationBuilder.RenameIndex(
                name: "IX_comentarios_UsuarioId",
                table: "Comentario",
                newName: "IX_Comentario_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_comentarios_LivroId",
                table: "Comentario",
                newName: "IX_Comentario_LivroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario",
                column: "ComentarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Livros_LivroId",
                table: "Comentario",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "LivroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Usuarios_UsuarioId",
                table: "Comentario",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
