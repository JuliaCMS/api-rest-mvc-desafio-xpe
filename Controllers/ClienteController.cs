using Microsoft.AspNetCore.Mvc;
using mvc_rest_api.Models.Entities;
using mvc_rest_api.Models.Services;

namespace mvc_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        #region ClienteService Constructor Injection
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> FindAll()
        {
            return Ok(await _service.ListarTodosAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindById(int id)
        {
            var c = await _service.ObterPorIdAsync(id);
            if (c == null) return NotFound();
            return Ok(c);
        }

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> FindByName(string nome)
        {
            var lista = await _service.BuscarPorNomeAsync(nome);
            if (!lista.Any()) return NotFound();
            return Ok(lista);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Cliente cliente)
        {
            await _service.CriarAsync(cliente);
            return CreatedAtAction(nameof(FindById), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id) return BadRequest();
            var existing = await _service.ObterPorIdAsync(id);
            if (existing == null) return NotFound();
            await _service.AtualizarAsync(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _service.ObterPorIdAsync(id);
            if (existing == null) return NotFound();
            await _service.DeletarAsync(id);
            return NoContent();
        }

        [HttpGet("count")]
        public async Task<IActionResult> Count()
        {
            return Ok(new { count = await _service.ContarAsync() });
        }
    }
}
