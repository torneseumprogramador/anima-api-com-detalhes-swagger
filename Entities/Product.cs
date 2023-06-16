using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities;

public record Product
{
    public int Id {get;set;}

    public string Name {get;set;} = default!;

    public string Description {get;set;} = default!;

    public double Price {get;set;} = default!;
}