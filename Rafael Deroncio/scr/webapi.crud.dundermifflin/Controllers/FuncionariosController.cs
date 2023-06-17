using Microsoft.AspNetCore.Mvc;
using webapi.crud.dundermifflin.Requests;
using webapi.crud.dundermifflin.Services.Interfaces;

namespace webapi.crud.dundermifflin.controllers;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosController : ControllerBase
{
    private readonly IFuncionarioService _funcionarioService;
    public FuncionariosController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _funcionarioService.GetFuncionarios());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _funcionarioService.GetFuncionario(id));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] FuncionarioRequest funcionario)
    {
        return Ok(await _funcionarioService.CreateFuncionario(funcionario));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] FuncionarioRequest funcionario)
    {
        return Ok(await _funcionarioService.UpdateFuncionario(id, funcionario));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _funcionarioService.DeleteFuncionario(id));
    }
}
