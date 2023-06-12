namespace Domain.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public DateTimeOffset AnoDePublicacao { get; set; }
        public string? ISBN { get; set; }
        public ICollection<Categoria>? Categorias { get; set; }
        public ICollection<Author>? Authors { get; set; }
        //public ICollection<Comentario>? Comentarios { get; set; }
        //public ICollection<Emprestimo>? Emprestimos { get; set; }

        //public ICollection<Editora>? Editoras { get; set; }
    }
}