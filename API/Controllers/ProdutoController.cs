using Microsoft.AspNetCore.Mvc;
using RestApiProject.Application.Dtos;
using RestApiProject.Application.Interfaces;
using System.Threading.Tasks;

namespace RestApiProject.API.Controllers
{
    [ApiController]
    [Route("produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] ProdutoDto produtoDto
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _applicationServiceProduto.InserirAsync(produtoDto);
            return Ok("Produto cadastrado com sucesso!");
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProdutoDto>> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = await _applicationServiceProduto.ObterPorIdAsync(id);
            return Ok(cliente);
        }
    }
}
