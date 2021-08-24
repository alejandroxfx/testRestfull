using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restfull.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restfull.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MockDataBase _mockdatabase = new MockDataBase();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        [HttpPost]
        public IActionResult FindHobbie([FromBody] Hobbie hobbie)
        {
            try
            {
                Hobbie findHobbie = null;

                if (!String.IsNullOrEmpty(hobbie.Name))
                    findHobbie = _mockdatabase.GetTop10Hobbies().FirstOrDefault(m => m.Name.Trim().ToLower().Contains(hobbie.Name.Trim().ToLower()));

                return Ok(new { success = true, Hobbie = findHobbie });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddHobbie([FromBody] Hobbie hobbie)
        {
            try
            {
                var result = _mockdatabase.Add(hobbie);

                return Ok(new { success = result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
