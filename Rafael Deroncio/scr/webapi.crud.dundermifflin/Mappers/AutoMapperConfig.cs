using AutoMapper;
using webapi.crud.dundermifflin.Mappers.Profiles;

namespace webapi.crud.dundermifflin.Mappers;

class AutoMapperConfig
{
    public static MapperConfiguration RegisterMappings()
    {
        return new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new ModelToResponseProfile());
                cfg.AddProfile(new ModelToArgumentProfile());
                cfg.AddProfile(new ModelToEntitieProfile());
                cfg.AddProfile(new EntitieToArgumentProfile());
                cfg.AddProfile(new ArgumentToRequestProfile());
                cfg.AddProfile(new RequestToResponseProfile());
            });
    }
}