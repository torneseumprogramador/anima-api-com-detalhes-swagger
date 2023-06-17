using Microsoft.EntityFrameworkCore;
using webapi.crud.dundermifflin.Arguments;
using webapi.crud.dundermifflin.Contexts;
using webapi.crud.dundermifflin.Entities;
using webapi.crud.dundermifflin.Mappers;
using webapi.crud.dundermifflin.Models;
using webapi.crud.dundermifflin.Repositories.Interfaces;

namespace webapi.crud.dundermifflin.Repository;

public class FuncionarioRepository : IFuncionarioRepository
{
    private readonly DunderMifflinDatabaseContext _databaseContext;
    private readonly IObjectConverter _mapper;

    public FuncionarioRepository(DunderMifflinDatabaseContext context, IObjectConverter mapper)
    {
        _databaseContext = context;
        _mapper = mapper;
    }

    public async Task<bool> CreateAsync(FuncionarioArgument funcionario, bool commit = true)
    {
        Funcionario funcionarioEntity = _mapper.Map<Funcionario>(funcionario);

        await _databaseContext.Funcionarios.AddAsync(funcionarioEntity);

        if (commit)
            return await _databaseContext.SaveChangesAsync() > 0;

        return false;
    }

    public async Task<bool> DeleteAsync(int id, bool commit = true)
    {
        if (commit)
        {
            Funcionario entity = await _databaseContext.Funcionarios.FindAsync(id);
            _databaseContext.Funcionarios.Remove(entity);
            return await _databaseContext.SaveChangesAsync() > 0;
        }


        return false;
    }

    public async Task<IEnumerable<FuncionarioModel>> GetAllAsync()
    {
        IEnumerable<Funcionario> funcionarios = await _databaseContext.Funcionarios.AsNoTracking().ToListAsync();
        return _mapper.Map<IEnumerable<FuncionarioModel>>(funcionarios);
    }

    public async Task<FuncionarioModel> GetByIdAsync(int id)
    {
        Funcionario funcionario = await _databaseContext.Funcionarios.FindAsync(id);
        return _mapper.Map<FuncionarioModel>(funcionario);
    }


    public async Task<bool> UpdateAsync(FuncionarioArgument funcionario, bool commit = true)
    {
        if (commit)
        {
            Funcionario entity = _mapper.Map<Funcionario>(funcionario);
            _databaseContext.Funcionarios.Update(entity);
            return await _databaseContext.SaveChangesAsync() > 0;
        }

        return false;
    }
}