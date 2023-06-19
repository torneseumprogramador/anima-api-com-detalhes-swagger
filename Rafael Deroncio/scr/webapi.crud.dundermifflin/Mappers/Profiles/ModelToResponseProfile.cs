using AutoMapper;
using webapi.crud.dundermifflin.Models;
using webapi.crud.dundermifflin.Responses;

namespace webapi.crud.dundermifflin.Mappers.Profiles;

public class ModelToResponseProfile : Profile
{
    public ModelToResponseProfile()
    {
        CreateMap<FuncionarioModel, FuncionarioResponse>().ReverseMap();
    }
}