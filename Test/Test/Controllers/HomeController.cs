using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NationalZoo.Models;

namespace NationalZoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Zookeeper()
        {
            return View();
        }

        public IActionResult Animal()
        {
            AnimalViewModel avm = new AnimalViewModel();

            List<DTO.Animal> animals = new List<DTO.Animal>()
            {
                new DTO.Animal{ Id = 1, Name = "Bernard", Species = "Snake", Weight = 23.23},
                new DTO.Animal{ Id = 2, Name = "Ralph", Species = "Iguana", Weight = 12.83},
                new DTO.Animal{ Id = 3, Name = "Monte", Species = "Lemur", Weight = 17.45},
            };
            avm.Animals = animals;
            return View(avm);
        }

        public IActionResult Exhibit()
        {
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
    }
}
