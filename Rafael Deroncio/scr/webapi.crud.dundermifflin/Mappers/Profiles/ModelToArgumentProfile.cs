using AutoMapper;
using webapi.crud.dundermifflin.Arguments;
using webapi.crud.dundermifflin.Models;

namespace webapi.crud.dundermifflin.Mappers.Profiles;

public class ModelToArgumentProfile : Profile
{
    public ModelToArgumentProfile()
    {
        CreateMap<FuncionarioModel, FuncionarioArgument>().ReverseMap();
    }
}