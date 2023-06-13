
namespace Domain.Models
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public int UsuarioId { get; set; }
        public int LivroId { get; set; }
        public string Mensagem  { get; set; }
        public double Avaliacao { get; set; }
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
    }
}
