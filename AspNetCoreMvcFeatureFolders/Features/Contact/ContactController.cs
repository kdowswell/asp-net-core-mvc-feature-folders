using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFeatureFolders.Features.Contact
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your contact page.";

            return View("Contact");
        }
    }
}
