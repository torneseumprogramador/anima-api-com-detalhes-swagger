using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.DTOs;

[DisplayName("ClienteDTO")]
public record ClientDTO
{
    [JsonPropertyName("nome")]
    [Required(ErrorMessage = "O nome não pode ser fazio")]
    public string Name {get;set;} = default!;


    [JsonPropertyName("telefone")]
    [Required(ErrorMessage = "O telefone não pode ser fazio")]
    public string Phone {get;set;} = default!;

    [JsonPropertyName("observacao")]
    public string Obs { get; set; } = default!;
}