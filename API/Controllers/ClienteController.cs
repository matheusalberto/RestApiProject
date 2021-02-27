using Microsoft.AspNetCore.Mvc;
using RestApiProject.Application.Dtos;
using RestApiProject.Application.Interfaces;
using System.Threading.Tasks;

namespace RestApiProject.API.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] ClienteDto clienteDto
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _applicationServiceCliente.InserirAsync(clienteDto);
            return Ok("Cliente cadastrado com sucesso!");
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClienteDto>> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = await _applicationServiceCliente.ObterPorIdAsync(id);
            return Ok(cliente);
        }
    }
}
