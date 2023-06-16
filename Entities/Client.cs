using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.Entities;

[DisplayName("Cliente")]
[Table("clients")]
public record Client
{
    [Key]
    [Column("id")]
    public int Id {get;set;}

    [JsonPropertyName("nome")]
    [Column("name")]
    [MaxLength(100)]
    [Required(ErrorMessage = "O nome não pode ser fazio")]
    public string Name {get;set;} = default!;


    [JsonPropertyName("telefone")]
    [Column("phone")]
    [MaxLength(20)]
    [Required(ErrorMessage = "O telefone não pode ser fazio")]
    public string Phone {get;set;} = default!;

    [JsonPropertyName("observacao")]
    [Column("obs", TypeName = "text")]
    public string Obs { get; set; } = default!;
}