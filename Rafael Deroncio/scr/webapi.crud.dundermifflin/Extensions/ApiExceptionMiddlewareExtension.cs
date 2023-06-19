using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using webapi.crud.dundermifflin.Responses;

namespace webapi.crud.dundermifflin.Extensions;

public static class ApiExceptionMiddlewareExtension
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(error =>
        {
            error.Run(async context =>
            {
                // Implementação do Erro
                context.Response.ContentType = "application/json"; // return json

                IExceptionHandlerFeature? contextFeature = context.Features.Get<IExceptionHandlerFeature>();// get errors

                if(contextFeature != null)
                {
                    FuncionarioExceptionResponse error = new()
                    {
                        Titulo = "Erro",
                        Mensagens = new string[1]{contextFeature.Error.Message}
                    };

                    await context.Response.WriteAsync(error.ToString());
                }
            });
        });
    }
}