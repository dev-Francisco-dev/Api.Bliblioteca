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
            return Ok(Livros);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var livro = _livrosRepository.Get(id);
            if (livro == null)
            {
                return NotFound("Usuario N�o cadastrado!");
            }
            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Livro livro)
        {
            _livrosRepository.Insert(livro);
            return Ok(livro);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Livro livro)
        {
            _livrosRepository.Update(livro);
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