using Domain.Models;

namespace Domain.DTO
{
    public class LivroGetAllDto
    {
        public int LivroId { get; set; }
        public string? Titulo { get; set; }
        public DateTimeOffset AnoDePublicacao { get; set; }
        public string? ISBN { get; set; }
    
    }
}
