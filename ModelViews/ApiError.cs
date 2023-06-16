using System.Text.Json.Serialization;

namespace WebApi.ModelViews;

public struct ApiError
{
    [JsonPropertyName("Mensagem")]
    public string Message { get; set;}

    [JsonPropertyName("CodigoDeStatusHttp")]
    public int StatusCode { get; set;}
}