using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFeatureFolders.Features.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }
    }
}
