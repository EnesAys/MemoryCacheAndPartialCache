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
        private readonly IMemoryCacheService _memoryCacheService;

        public HomeController(IMemoryCacheService memoryCacheService)
        {            
            _memoryCacheService = memoryCacheService;
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            var teamSquad = _memoryCacheService.GetTeamSquad();
            return View(teamSquad);
        }
    }
}
