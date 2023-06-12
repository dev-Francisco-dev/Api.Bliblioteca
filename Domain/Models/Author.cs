namespace Domain.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Nome { get; set; }
        public string? Pais { get; set; }
        public ICollection<Livro>? livros { get; set; }
    }
}
