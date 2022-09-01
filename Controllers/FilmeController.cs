using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;
        [HttpPost]
        public IActionResult AdicionarFilme([FromBody]Filme filme)
        {
            filme.ID = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperarFilmeID),new {Id = filme.ID},filme);
        }
        [HttpGet]
        public IActionResult RecuperarFilme()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmeID(int id)
        {
            Filme filme =  filmes.FirstOrDefault(filme => filme.ID == id);
            if(filme != null)
            {
                return Ok(filme);

            }
            else
            {
                return NotFound();
            }
        }

    }
}