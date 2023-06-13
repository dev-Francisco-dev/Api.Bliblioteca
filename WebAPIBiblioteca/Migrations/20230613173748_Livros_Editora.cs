using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Livros_Editora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editoras",
                columns: table => new
                {
                    EditoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoras", x => x.EditoraId);
                });

            migrationBuilder.CreateTable(
                name: "EditoraLivro",
                columns: table => new
                {
                    EditorasEditoraId = table.Column<int>(type: "int", nullable: false),
                    livrosLivroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditoraLivro", x => new { x.EditorasEditoraId, x.livrosLivroId });
                    table.ForeignKey(
                        name: "FK_EditoraLivro_Editoras_EditorasEditoraId",
                        column: x => x.EditorasEditoraId,
                        principalTable: "Editoras",
                        principalColumn: "EditoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditoraLivro_Livros_livrosLivroId",
                        column: x => x.livrosLivroId,
                        principalTable: "Livros",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditoraLivro_livrosLivroId",
                table: "EditoraLivro",
                column: "livrosLivroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditoraLivro");

            migrationBuilder.DropTable(
                name: "Editoras");
        }
    }
}
