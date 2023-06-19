using Microsoft.AspNetCore.Mvc;
using Vitor.Bandeira.Models;
using Vitor.Bandeira.Repository;


namespace Vitor.Bandeira.Controllers.v1
{

    [ApiController]
    
    [Route("/v1/veiculo")]
    public class Veiculov1Controller : ControllerBase
    {
        private readonly IVeiculoRepository _veiculo;
        public Veiculov1Controller(IVeiculoRepository veiculo)
        {
            _veiculo = veiculo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Veiculo>> Index()
        {
            var veiculo = _veiculo.Get();
            return Ok(veiculo);
        }

        [HttpGet("id: int", Name = "ObterVeiculo")]

        public ActionResult<Veiculo> GetById(int id)
        {
            var veiculo = _veiculo.GetById(p => p.VeiculoId == id);
            if (veiculo == null) return NotFound();
            return Ok(veiculo);
        }

        [HttpPost]
        public ActionResult Post(Veiculo veiculo)
        {
            if (veiculo == null) return BadRequest();

            _veiculo.Add(veiculo);

            return new CreatedAtRouteResult("ObterVeiculo", new { id = veiculo.VeiculoId }, veiculo);
        }

        [HttpPut("id: int")]
        public ActionResult Put(int id, Veiculo veiculo)
        {

            if (id != veiculo.VeiculoId) return BadRequest();
            _veiculo.Update(veiculo);

            return Ok(veiculo);
        }

        [HttpDelete("id : int")]
        public ActionResult<Veiculo> Delete(int id)
        {
            var veiculo = _veiculo.GetById(v => v.VeiculoId == id);
            if (veiculo == null) return BadRequest();

            _veiculo.Remove(veiculo);

            return NoContent();
        }

    }

}