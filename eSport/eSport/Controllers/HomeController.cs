using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public RedirectResult RedirectToSwaggerUi()
        {
            return Redirect("/swagger/");
        }
    }
}
