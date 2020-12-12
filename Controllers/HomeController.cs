using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MemoryCacheAndPartialCache.Models;
using MemoryCacheAndPartialCache.Services;

namespace MemoryCacheAndPartialCache.Controllers
{
    public class HomeController : Controller
    {        
        private readonly ITeamService _teamService;

        public HomeController(ITeamService teamService)
        {            
            _teamService = teamService;
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            var players = _teamService.GetPlayers();
            var teamSquad = new TeamSquad{
                CheckTime = DateTime.Now,
                Players = players
            };
            return View(teamSquad);
        }
    }
}
