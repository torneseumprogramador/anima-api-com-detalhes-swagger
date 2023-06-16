using Microsoft.AspNetCore.Mvc;
using WebApi.ModelViews;

namespace webapi.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult Index()
    {
        return StatusCode(200, new Home {
            Message = "Bem vindo a minha api"
        });
    }
}
