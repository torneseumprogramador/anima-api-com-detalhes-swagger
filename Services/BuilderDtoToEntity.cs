
using System;
using System.Reflection;

namespace WebApi.Services;

public class BuilderDtoToEntity
{
    public T Build<T, TD>(TD dto) where T : new()
    {
        var entity = new T();
        return Build(entity, dto);
    }

    public T Build<T, TD>(T entity, TD dto) where T : new()
    {
        if (entity is null) return entity;
        if (dto is null) return entity;

        var dtoType = typeof(TD);
        var entityType = typeof(T);

        foreach (var dtoProperty in dtoType.GetProperties())
        {
            var entityProperty = entityType.GetProperty(dtoProperty.Name);
            if (entityProperty != null && entityProperty.CanWrite)
            {
                var value = dtoProperty.GetValue(dto);
                entityProperty.SetValue(entity, value);
            }
        }

        return entity;
    }
}
