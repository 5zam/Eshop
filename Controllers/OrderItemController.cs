using EcommerceDay1.Context;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceDay1.Controllers
{
    public class OrderItemController : Controller
    {
        private ApplicationDbContext _context;

        public OrderItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
