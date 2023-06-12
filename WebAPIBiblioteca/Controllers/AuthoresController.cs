using Microsoft.AspNetCore.Mvc;
using WebAPIBiblioteca.Repository;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAuthoresRepository _authoresRepository;

        public AutoresController(IAuthoresRepository authoresRepository)
        {
            _authoresRepository = authoresRepository;
        }
        
        [HttpGet]
        public ActionResult GetAll()
        {
            var Livros = _authoresRepository.GetAll();
            return Ok(Livros);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var livro = _authoresRepository.Get(id);
            if (livro == null)
            {
                return NotFound("Usuario Não cadastrado!");
            }
            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Author author)
        {
            _authoresRepository.Insert(author);
            return Ok(author);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Author author)
        {
            _authoresRepository.Update(author);
            return Ok(author);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _authoresRepository.Delete(id);
            return Ok();
        }
    }
}