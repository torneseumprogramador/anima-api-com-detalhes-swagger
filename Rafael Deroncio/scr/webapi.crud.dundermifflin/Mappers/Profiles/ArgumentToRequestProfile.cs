using AutoMapper;
using webapi.crud.dundermifflin.Arguments;
using webapi.crud.dundermifflin.Requests;

namespace webapi.crud.dundermifflin.Mappers.Profiles;

public class ArgumentToRequestProfile : Profile
{
    public ArgumentToRequestProfile()
    {
        CreateMap<FuncionarioArgument, FuncionarioRequest>().ReverseMap();
    }
}