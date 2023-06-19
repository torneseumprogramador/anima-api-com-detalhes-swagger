using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using webapi.crud.dundermifflin.Entities;
using webapi.crud.dundermifflin.Models;

namespace webapi.crud.dundermifflin.Mappers.Profiles;

public class ModelToEntitieProfile : Profile
{
    public ModelToEntitieProfile()
    {
        CreateMap<Funcionario, FuncionarioModel>().ReverseMap();
    }
}