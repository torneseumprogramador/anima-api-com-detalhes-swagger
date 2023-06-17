using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.crud.dundermifflin.Mappers;

public interface IObjectConverter
{
    T Map<T>(object source);
    D Map<T, D>(T source, D destination);
}