using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using WebAPIBiblioteca.Repository;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivrosRepository _livrosRepository;

        public LivrosController(ILivrosRepository livrosRepository)
        {
            _livrosRepository = livrosRepository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var Livros = _livrosRepository.GetAll();
            List<LivroGetAllDto> livroGetAllDtos = new List<LivroGetAllDto>();
            foreach (var livro in Livros)
            {
               livroGetAllDtos.Add(new LivroGetAllDto { 
                   LivroId = livro.LivroId,
                   Titulo = livro.Titulo,
                   AnoDePublicacao = livro.AnoDePublicacao,
                   ISBN = livro.ISBN,
               });
            }
            return Ok(livroGetAllDtos);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var livro = _livrosRepository.Get(id);
            if (livro == null)
            {
                return NotFound("Não cadastrado!");
            }

            LivroGetAllDto livroGetAllDto = new LivroGetAllDto
            {
                LivroId = livro.LivroId,
                Titulo = livro.Titulo,
                AnoDePublicacao = livro.AnoDePublicacao,
                ISBN = livro.ISBN
            };

            return Ok(livroGetAllDto);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] LivroInsertDto livro)
        {
                    
            if (livro != null)
            {
                Livro novoLivro = new Livro()
                {
                    Titulo = livro.Titulo!,
                    AnoDePublicacao = livro.AnoDePublicacao,
                    ISBN = livro.ISBN
                };
                _livrosRepository.Insert(novoLivro);
            }
            
            return Ok("Livro Inserido com Sucesso!");
        }

        [HttpPut]
        public IActionResult Update([FromBody] LivroGetAllDto livro)
        {
            if (livro != null)
            {
                Livro atualizaLivro = new Livro()
                {
                    LivroId = livro.LivroId,
                    Titulo = livro.Titulo!,
                    AnoDePublicacao = livro.AnoDePublicacao,
                    ISBN = livro.ISBN
                };
                _livrosRepository.Update(atualizaLivro);
            }
            
            return Ok(livro);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _livrosRepository.Delete(id);
            return Ok();
        }
    }
}