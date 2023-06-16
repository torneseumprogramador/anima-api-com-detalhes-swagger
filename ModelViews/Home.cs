using System.Text.Json.Serialization;

namespace WebApi.ModelViews;

public struct Home
{
    [JsonPropertyName("Mensagem")]
    public string Message { get; set;}
}