namespace Domain.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string Email { get; set; }
        public string? Endereco { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Livro>? Livros { get; set; }
        public ICollection<Comentario>? Comentarios { get; set; }


    }
}
