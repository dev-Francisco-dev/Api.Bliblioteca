﻿namespace Domain.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public ICollection<Livro>? Livros { get; set; }
    }
}
