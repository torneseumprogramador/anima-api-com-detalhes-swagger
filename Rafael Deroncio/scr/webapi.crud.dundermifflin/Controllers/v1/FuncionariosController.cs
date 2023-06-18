using Microsoft.AspNetCore.Mvc;
using webapi.crud.dundermifflin.Exceptions;
using webapi.crud.dundermifflin.Requests;
using webapi.crud.dundermifflin.Responses;
using webapi.crud.dundermifflin.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;


namespace webapi.crud.dundermifflin.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class FuncionariosController : ControllerBase
{
    private readonly IFuncionarioService _funcionarioService;

    public FuncionariosController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    /// <summary>
    /// Obtém todos os funcionários.
    /// </summary>
    [HttpGet]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(IEnumerable<FuncionarioResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), StatusCodes.Status503ServiceUnavailable)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), StatusCodes.Status400BadRequest)]
    [SwaggerOperation(Tags = new[] { "get", "recupera funcionarios" }, Summary = "Obtém todos os funcionários", Description = "Retorna uma lista de todos os funcionários.")]
    [ApiExplorerSettings()]
    public async Task<IActionResult> Get()
    {
        return Ok(await _funcionarioService.GetFuncionarios());
    }

    /// <summary>
    /// Obtém um funcionário pelo ID.
    /// </summary>
    /// <param name="id">ID do funcionário.</param>
    [HttpGet("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(FuncionarioResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), StatusCodes.Status503ServiceUnavailable)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), StatusCodes.Status400BadRequest)]
    [SwaggerOperation(Tags = new[] { "get", "recupera funcionario" },Summary = "Obtém um funcionário pelo ID", Description = "Retorna os detalhes de um funcionário com base no seu ID.")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _funcionarioService.GetFuncionario(id));
    }

    /// <summary>
    /// Cria um novo funcionário.
    /// </summary>
    /// <param name="funcionario">Dados do funcionário a ser criado.</param>
    [HttpPost]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(FuncionarioResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), StatusCodes.Status503ServiceUnavailable)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), StatusCodes.Status400BadRequest)]
    [SwaggerOperation(Tags = new[] { "post", "cria funcionario" }, Summary = "Cria um novo funcionário", Description = "Cria um novo funcionário com base nos dados fornecidos.")]
    public async Task<IActionResult> Post([FromBody] FuncionarioRequest funcionario)
    {
        return Ok(await _funcionarioService.CreateFuncionario(funcionario));
    }

    /// <summary>
    /// Atualiza um funcionário existente.
    /// </summary>
    /// <param name="id">ID do funcionário a ser atualizado.</param>
    /// <param name="funcionario">Novos dados do funcionário.</param>
    [HttpPut("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), StatusCodes.Status503ServiceUnavailable)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), StatusCodes.Status400BadRequest)]
    [SwaggerOperation(Tags = new[] { "put", "atualiza funcionario" }, Summary = "Atualiza um funcionário existente", Description = "Atualiza os dados de um funcionário existente com base no ID fornecido.")]
    public async Task<IActionResult> Put(int id, [FromBody] FuncionarioRequest funcionario)
    {
        return Ok(await _funcionarioService.UpdateFuncionario(id, funcionario));
    }

    /// <summary>
    /// Exclui um funcionário pelo ID.
    /// </summary>
    /// <param name="id">ID do funcionário a ser excluído.</param>
    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), StatusCodes.Status503ServiceUnavailable)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), StatusCodes.Status400BadRequest)]
    [SwaggerOperation(Tags = new[] { "delete", "deleta funcionario" }, Summary = "Exclui um funcionário pelo ID", Description = "Exclui um funcionário com base no seu ID.")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _funcionarioService.DeleteFuncionario(id));
    }
}
