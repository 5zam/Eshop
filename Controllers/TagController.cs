using EcommerceDay1.Context;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceDay1.Controllers
{
    public class TagController : Controller
    {
        private ApplicationDbContext _context;
        public TagController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
