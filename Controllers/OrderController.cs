using EcommerceDay1.Context;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceDay1.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
