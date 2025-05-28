using EcommerceDay1.Context;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceDay1.Controllers
{
    public class ReviewController : Controller
    {
        private ApplicationDbContext _context;
        public ReviewController(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }
    }
}
