using Microsoft.AspNetCore.Mvc;
using WebApi.ModelViews;
using WebApi.Db;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.DTOs;
using WebApi.Services;
using WebApi.Filters;

namespace webapi.Controllers.v1;

// [ApiController] // para habilitar a validação padrão
[Authentication]
[Route("/clientes")]
public class ClientsController : ControllerBase
{
    public ClientsController(DbAppContext context)
    {
        this._context = context;
    }

    private DbAppContext _context;

    [HttpGet]
    public async Task<ActionResult> Index()
    {
        var clients = await _context.Clients.ToListAsync();
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
