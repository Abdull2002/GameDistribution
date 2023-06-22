using GameDistribution.Data;
using GameDistribution.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameDistribution.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchValue)
        {
           
            return View();
        }

    }
}
