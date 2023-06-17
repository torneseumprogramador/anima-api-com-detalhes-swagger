using webapi.crud.dundermifflin.Requests;
using webapi.crud.dundermifflin.Responses;
using webapi.crud.dundermifflin.Repositories.Interfaces;
using webapi.crud.dundermifflin.Services.Interfaces;
using webapi.crud.dundermifflin.Entities;
using webapi.crud.dundermifflin.Models;
using webapi.crud.dundermifflin.Mappers;
using webapi.crud.dundermifflin.Arguments;

namespace webapi.crud.dundermifflin.Services;

public class FuncionarioService : IFuncionarioService
{
    private readonly IFuncionarioRepository _funcionarioRepository;
    private readonly IObjectConverter _mapper;

    public FuncionarioService(IFuncionarioRepository funcionarioRepository, IObjectConverter mapper)
    {
        _funcionarioRepository = funcionarioRepository;
        _mapper = mapper;
    }

    public async Task<FuncionarioResponse> CreateFuncionario(FuncionarioRequest funcionario)
    {
        FuncionarioArgument argument = _mapper.Map<FuncionarioArgument>(funcionario); 

        if(await _funcionarioRepository.CreateAsync(argument))
        {
            return _mapper.Map<FuncionarioResponse>(funcionario);
        }
        
        return null;
    }

    public async Task<bool> DeleteFuncionario(int id)
    {
        FuncionarioModel funcionario = await _funcionarioRepository.GetByIdAsync(id);
        if (funcionario != null)
            return await _funcionarioRepository.DeleteAsync(id);
        return false;
    }

    public async Task<FuncionarioResponse> GetFuncionario(int id)
    {
        FuncionarioModel funcionario = await _funcionarioRepository.GetByIdAsync(id);
        return _mapper.Map<FuncionarioResponse>(funcionario);
    }

    public async Task<IEnumerable<FuncionarioResponse>> GetFuncionarios()
    {
        IEnumerable<FuncionarioModel> funcionario = await _funcionarioRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<FuncionarioResponse>>(funcionario);
    }

    public async Task<bool> UpdateFuncionario(int id, FuncionarioRequest funcionario)
    {
        FuncionarioModel funcionarioModel = await _funcionarioRepository.GetByIdAsync(id);

        if (funcionarioModel != null)
        {
            FuncionarioArgument funcionarioArgument = _mapper.Map<FuncionarioArgument>(funcionario);
            return await _funcionarioRepository.UpdateAsync(funcionarioArgument);
        }
        return false;
    }
}