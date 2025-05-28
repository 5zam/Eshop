using EcommerceDay1.Context;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceDay1.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
