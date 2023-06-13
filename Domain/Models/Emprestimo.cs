namespace Domain.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public int LivroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTimeOffset DataEmprestimo { get; set; }
        public DateTimeOffset DataEntregaEmprestimo { get; set; }
        public Usuario Usuario { get; set;}
        public Livro Livro { get; set;}

    }
}
