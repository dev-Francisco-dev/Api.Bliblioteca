namespace Domain.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string? Nome { get; set;}
        public string? Pais { get; set;}
        public ICollection<Livro>? livros { get; set;}
    }
}
