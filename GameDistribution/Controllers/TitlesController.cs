using GameDistribution.Data;
using GameDistribution.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameDistribution.Controllers
{
    public class TitlesController : Controller
    {
        ApplicationDbContext _context;

        public TitlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
