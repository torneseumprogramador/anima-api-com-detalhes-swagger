using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities;

public record OrderItem
{
    public int Id {get;set;}

    public int OrderId {get;set;}
    public Order Order {get;set;} = default!;

    public int ProductId {get;set;}
    public Product Product {get;set;} = default!;

    public int Length {get;set;}
    
    public double Price {get;set;}
}