using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFeatureFolders.Features.TroubleTickets.Submit
{
    [Area("TroubleTickets")]
    public class SubmitController : Controller
    {
        public IActionResult Index()
        {
            return View("Submit");
        }

        [HttpPost]
        public IActionResult Submit(SubmitCommand command)
        {
            //Send command

            return RedirectToAction("Index", "List", new { area = "TroubleTickets" });
        }
    }
}
