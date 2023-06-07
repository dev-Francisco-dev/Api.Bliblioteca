using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebAPIBiblioteca.Repository;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly ILivrosRepository _livroRepository;

        public BibliotecaController(ILivrosRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var Livros = _livroRepository.GetAll();
            return Ok(Livros);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var livro = _livroRepository.Get(id);
            if(livro == null)
            {
                return NotFound("Usuario Não cadastrado!");
            }
            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Livro livro)
        {
            _livroRepository.Insert(livro);
            return Ok(livro);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Livro livro)
        {
            _livroRepository.Update(livro);
            return Ok(livro);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _livroRepository.Delete(id);
            return Ok();
        }




    }
}