using Microsoft.AspNetCore.Mvc;
using webapi.crud.dundermifflin.Exceptions;
using webapi.crud.dundermifflin.Requests;
using webapi.crud.dundermifflin.Responses;
using webapi.crud.dundermifflin.Services.Interfaces;

namespace webapi.crud.dundermifflin.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    [ProducesResponseType(typeof(IEnumerable<FuncionarioResponse>), 200)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), 503)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), 400)]
    public async Task<IActionResult> Get()
    {
        return Ok(await _funcionarioService.GetFuncionarios());
    }

    /// <summary>
    /// Obtém um funcionário pelo ID.
    /// </summary>
    /// <param name="id">ID do funcionário.</param>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(FuncionarioResponse), 200)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), 503)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), 400)]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _funcionarioService.GetFuncionario(id));
    }

    /// <summary>
    /// Cria um novo funcionário.
    /// </summary>
    /// <param name="funcionario">Dados do funcionário a ser criado.</param>
    [HttpPost]
    [ProducesResponseType(typeof(FuncionarioResponse), 200)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), 503)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), 400)]
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
    [ProducesResponseType(typeof(bool), 200)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), 503)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), 400)]
    public async Task<IActionResult> Put(int id, [FromBody] FuncionarioRequest funcionario)
    {
        return Ok(await _funcionarioService.UpdateFuncionario(id, funcionario));
    }

    /// <summary>
    /// Exclui um funcionário pelo ID.
    /// </summary>
    /// <param name="id">ID do funcionário a ser excluído.</param>
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(bool), 200)]
    [ProducesResponseType(typeof(FuncionarioServiceUnavailableException), 503)]
    [ProducesResponseType(typeof(FuncionarioBadRequestException), 400)]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _funcionarioService.DeleteFuncionario(id));
    }
}