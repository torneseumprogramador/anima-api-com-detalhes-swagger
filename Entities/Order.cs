using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WebApi.Entities;

[JsonObject(Title = "Pedidos")]
[Table("orders")]
public record Order
{
    public Order()
    {
        this.Date = DateTime.Now;
    }

    [Key]
    [Column("id")]
    public int Id {get;set;}

    [JsonPropertyName("cliente_id")]
    [Column("cliente_id")]
    [Required(ErrorMessage = "O cliente_id é obrigatório")]
    public int ClientId {get;set;}

    [Newtonsoft.Json.JsonIgnore]
    public Client Client {get;set;} = default!;

    [JsonPropertyName("valor_total")]
    [Column("total")]
    [Required(ErrorMessage = "O valor total é obrigatório")]
    public double Total {get;set;}

    [JsonPropertyName("date")]
    [Column("date")]
    public DateTime Date {get;set;}
}