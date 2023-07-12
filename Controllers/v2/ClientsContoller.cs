using Microsoft.AspNetCore.Mvc;
using WebApi.ModelViews;
using WebApi.Db;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.DTOs;
using WebApi.Services;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;
using WebApi.Filters;

namespace webapi.Controllers.v2;

[Authentication]
[ApiController] // para habilitar a validação padrão
// [CustomValidationExceptionFilter] // validação individual
[Route("/v2/clientes")]
public class ClientsController : ControllerBase
{
    public ClientsController(DbAppContext context)
    {
        this._context = context;
    }

    private DbAppContext _context;

    [Consumes(MediaTypeNames.Application.Json)]
    [SwaggerOperation(Summary = "Lista de clientes", Description = "Retorna uma lista de clientes paginado por 10")]
    [ProducesResponseType(200, Type = typeof(List<Client>))]
    [HttpGet]
    public async Task<ActionResult> Index()
    {
        var clients = await _context.Clients.Take(10).ToListAsync();
        return StatusCode(200, clients);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] ClientDTO clientDTO)
    {
        var client = new BuilderDtoToEntity().Build<Client, ClientDTO>(clientDTO);

        _context.Clients.Add(client);
        await _context.SaveChangesAsync();

        return StatusCode(201, client);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> Show([FromRoute] int id)
    {
        if(id < 1) return StatusCode(404, new ApiError { Message = "O id não pode ser menor do que 1", StatusCode = 404 });
        
        var client = await _context.Clients.FindAsync(id);
        if(client is null) return StatusCode(404, new ApiError { Message = "O registro não foi encontrado", StatusCode = 404 });

        return StatusCode(200, client);
    }

    /// <summary>
    /// Atualizar clientes
    /// </summary>
    /// <param name="id"></param>
    /// <param name="clientDTO"></param>
    /// <returns></returns>
    // [ApiExplorerSettings(GroupName="Clientes")]
    [SwaggerOperation(Tags = new[] { "put", "update" }, Summary = "Atualização do cliente", Description = "Faz atualização de todos os campos da entidade de cliente")]
    [ProducesResponseType(200, Type = typeof(Client))]
    [ProducesResponseType(404, Type = typeof(ApiError))]
    [ProducesResponseType(400, Type = typeof(ApiError))]
    [HttpPut("{id}")]
    public async Task<ActionResult> Update([FromRoute] int id, [FromBody] ClientDTO clientDTO)
    {
        if(id < 1) return StatusCode(404, new ApiError { Message = "O id não pode ser menor do que 1", StatusCode = 404 });
        
        var client = await _context.Clients.FindAsync(id);
        if(client is null) return StatusCode(404, new ApiError { Message = "O registro não foi encontrado", StatusCode = 404 });

        client = new BuilderDtoToEntity().Build<Client, ClientDTO>(client, clientDTO);
        
        _context.Clients.Update(client);
        await _context.SaveChangesAsync();

        return StatusCode(200, client);
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult> UpdateName([FromRoute] int id, [FromBody] ClientNameDTO clientNameDTO)
    {
        if(id < 1) return StatusCode(404, new ApiError { Message = "O id não pode ser menor do que 1", StatusCode = 404 });
        
        var client = await _context.Clients.FindAsync(id);
        if(client is null) return StatusCode(404, new ApiError { Message = "O registro não foi encontrado", StatusCode = 404 });

        client.Name = clientNameDTO.Name;

        _context.Clients.Update(client);
        await _context.SaveChangesAsync();

        return StatusCode(200, client);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Destroy([FromRoute] int id)
    {
        if(id < 1) return StatusCode(404, new ApiError { Message = "O id não pode ser menor do que 1", StatusCode = 404 });
        
        var client = await _context.Clients.FindAsync(id);
        if(client is null) return StatusCode(404, new ApiError { Message = "O registro não foi encontrado", StatusCode = 404 });

        _context.Clients.Remove(client);
        await _context.SaveChangesAsync();

        return StatusCode(204);
    }
}
