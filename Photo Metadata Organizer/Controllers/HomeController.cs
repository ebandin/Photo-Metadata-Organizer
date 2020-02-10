using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Photo_Metadata_Organizer.Models;


namespace Photo_Metadata_Organizer.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //if userid == 1 return view
            // else userid ==2 return notview
            _logger = logger;
        }

        public IActionResult Index()
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("listall", "Listall");
            actionChoices.Add("Search", "Search");
            actionChoices.Add("addnew", "Addnew");
            actionChoices.Add("filepathbuilder", "Filepathbuilder");
            ViewBag.actions = actionChoices;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search()
        {
            if (HttpContext.Session.GetString("Type") == "user")
            {
                
                
                return View();
                    //look for the table where the data is and return enumurables. 
            }
            else
            {
                //redirect to login page
                return View();
            }
        }
    }

}
