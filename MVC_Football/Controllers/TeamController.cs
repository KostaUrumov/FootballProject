using Database.Data;
using Database.Data.Common;
using Database.Data.Models;
using Football.Core.Contracts;
using Football.Core.Models;
using Football.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVC_Football.Controllers
{
    public class TeamController : Controller
    {
        private readonly IFootballService footballService;

        public TeamController(IFootballService _productService)
        {
            footballService = _productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewData["Title"] = "Add team";
            TeamDTO team = new TeamDTO();
            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TeamDTO team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }

            await footballService.Add(team);
            return View();
        }

       
        public async Task<IActionResult> ShowAllTeams()
        {
           
            var teams = await footballService.ShowAll();

            return View(teams);
        }
    }
}
