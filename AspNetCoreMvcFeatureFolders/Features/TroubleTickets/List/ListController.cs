using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFeatureFolders.Features.TroubleTickets.List
{
    [Area("TroubleTickets")]
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            //Call query here using id param to get data for View Model

            //Map result of query to View Model

            return View("List", new ListViewModel());
        }
    }
}
