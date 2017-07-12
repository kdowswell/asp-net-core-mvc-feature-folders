using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFeatureFolders.Features.TroubleTickets.Manage
{
    [Area("TroubleTickets")]
    public class ManageController : Controller
    {
        public IActionResult Index(int id)
        {
            //Call query here using id param to get data for View Model

            //Map result of query to View Model

            return View("Manage", new ManageViewModel());
        }

        [HttpPost]
        public IActionResult Manage(ManageCommand command)
        {
            //Send command to modify data for trouble ticket

            return RedirectToAction("Index", "List", new { area = "TroubleTickets" });
        }
    }
}
