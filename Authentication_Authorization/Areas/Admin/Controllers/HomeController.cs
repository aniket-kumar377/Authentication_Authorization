using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_Authorization.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Authorize(Roles="Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
