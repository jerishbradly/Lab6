using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string>
            {
                {"Phone","4161234567" },
                {"Email", "someone@isp.ca" },
                {"Facebook", "Facebook.com/mywebsite" }
            };
            return View(contacts);
        }
    }
}
