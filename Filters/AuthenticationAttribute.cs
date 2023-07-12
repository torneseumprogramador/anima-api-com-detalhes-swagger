#nullable disable

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;
using WebApi.ModelViews;

namespace WebApi.Filters
{
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string authorizationHeader = context.HttpContext.Request.Headers["Authorization"];
            if (!string.IsNullOrWhiteSpace(authorizationHeader) && authorizationHeader.StartsWith("Bearer "))
            {
                string token = authorizationHeader.Substring("Bearer ".Length);

                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                var validationUrl = $"{configuration["URLIdentityServer"]}/valid-token";
                
                var httpClient = new HttpClient();

                // Fazer a chamada HEAD
                var request = new HttpRequestMessage(HttpMethod.Head, validationUrl);
                request.Headers.Add("Authorization", $"Bearer {token}");
                try{
                    var response = await httpClient.SendAsync(request);

                    // Verificar o código de status da resposta
                    if (response.IsSuccessStatusCode)
                    {
                        await next(); // Continuar com a execução do próximo filtro ou ação
                        return;
                    }
                }
                catch {}
            }

            var result = new ObjectResult(new ApiError
            {
                Message = "Acesso negado, precisa de um token válido no header",
                StatusCode = 401,
            })
            {
                StatusCode = 401
            };

            context.Result = result;
        }
    }
}
