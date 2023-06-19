using AutoMapper;
using webapi.crud.dundermifflin.Models;
using webapi.crud.dundermifflin.Requests;
using webapi.crud.dundermifflin.Responses;

namespace webapi.crud.dundermifflin.Mappers.Profiles;

public class RequestToResponseProfile : Profile
{
    public RequestToResponseProfile()
    {
        CreateMap<FuncionarioRequest, FuncionarioResponse>().ReverseMap();
    }
}