using Database.Data;
using Database.Data.Common;
using Football.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVC_Football.Controllers
{
    public class TeamController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TeamDTO team)
        {
            return View();
        }
    }
}
