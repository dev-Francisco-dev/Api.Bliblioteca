using Domain.Models;

namespace Domain.DTO
{
    public class LivroInsertDto
    {
        
        public string? Titulo { get; set; }
        public DateTimeOffset AnoDePublicacao { get; set; }
        public string? ISBN { get; set; }
    
    }
}
