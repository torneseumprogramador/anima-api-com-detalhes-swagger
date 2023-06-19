#nullable disable

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;
using WebApi.ModelViews;

namespace WebApi.Filters;

public class CustomValidationExceptionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = context.ModelState
                .Where(x => x.Value.Errors.Any())
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors
                        .Select(e => e.ErrorMessage ?? e.Exception?.Message)
                        .ToArray()
                );

            var result = new ObjectResult(new ApiError
            {
                Message = JsonConvert.SerializeObject(errors),
                StatusCode = 400,
            })
            {
                StatusCode = 400
            };

            context.Result = result;
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Não é necessário implementar aqui, mas a interface exige sua implementação
    }
}
