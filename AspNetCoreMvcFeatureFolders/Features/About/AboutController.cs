using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFeatureFolders.Features.About
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";

            return View("About");
        }
    }
}
