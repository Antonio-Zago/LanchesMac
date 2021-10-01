using LanchesMac.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Controllers
{

    //O controller Home tem uma pasta em view associada a ele, chamada Home, dentro dessa pasta tem todas as páginas que o controlador home chama
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); //Chama a pasta view, como não foi definida o nome, chama pelo nome do método, no caso index
        }

        public IActionResult Privacy()
        {
            return View("Privacy"); //Chama pelo nome especificado, não pelo nome do método
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
