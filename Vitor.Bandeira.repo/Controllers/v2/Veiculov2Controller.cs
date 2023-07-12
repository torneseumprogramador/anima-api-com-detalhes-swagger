using Microsoft.AspNetCore.Mvc;
using Vitor.Bandeira.Models;
using Vitor.Bandeira.Repository;


namespace Vitor.Bandeira.Controllers.v2
{

    [ApiController]
    
    [Route("/v2/veiculo")]
    public class Veiculov2Controller : ControllerBase
    {
        private readonly IVeiculoRepository _veiculo;

        public Veiculov2Controller(IVeiculoRepository veiculo)
        {
            _veiculo = veiculo;            
        }

        [HttpGet]
        public IActionResult Index()
        {
           return Ok(new { Mensagem = "O loko bicho" });

        }
    }
}