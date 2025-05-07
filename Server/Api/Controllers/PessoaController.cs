using Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        public static readonly List<Pessoa> Pessoas = new()
    {
        new() { Id = 1, Nome = "Ana Silva",   Endereco = "Rua das Flores, 123", DataNascimento = new(1990, 5, 22) },
        new() { Id = 2, Nome = "Bruno Costa", Endereco = "Av. Paulista, 1000",  DataNascimento = new(1985, 11, 3) },
        new() { Id = 3, Nome = "Carla Souza", Endereco = "Rua Bahia, 45",       DataNascimento = new(2000, 1, 15) },
        new() { Id = 4, Nome = "Diego Ramos", Endereco = "Alameda Santos, 250", DataNascimento = new(1995, 8, 30) },
        new() { Id = 5, Nome = "Elisa Martins", Endereco = "Travessa Rio, 9",  DataNascimento = new(1978, 4, 10) }
    };


        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> GetAll()
            => Ok(Pessoas);

   
        [HttpGet("{id:int}")]
        public ActionResult<Pessoa> GetById(int id)
        {
            var pessoa = Pessoas.FirstOrDefault(p => p.Id == id);
            return pessoa is null ? NotFound() : Ok(pessoa);
        }


        [HttpPost]
        public ActionResult<Pessoa> Add([FromBody] Pessoa nova)
        {
            if (nova is null) return BadRequest();

            var id = Pessoas.Count() + 1;
            nova.Id = id;
            Pessoas.Add(nova);

            return Ok(nova);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] Pessoa atualizada)
        {
            if (atualizada is null || id != atualizada.Id) return BadRequest();

            var idx = Pessoas.FindIndex(p => p.Id == id);
            if (idx == -1) return NotFound();

            Pessoas[idx] = atualizada;
            return Ok();
        }

        // DELETE: api/pessoa/5
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var pessoa = Pessoas.FirstOrDefault(p => p.Id == id);
            
            if (pessoa is null) return NotFound();

            Pessoas.Remove(pessoa);
            return Ok();
        }


    }
}
