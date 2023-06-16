using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.DTOs;

[DisplayName("ClienteNomeDTO")]
public record ClientNameDTO
{
    [JsonPropertyName("nome")]
    [Required(ErrorMessage = "O nome não pode ser fazio")]
    public string Name {get;set;} = default!;
}