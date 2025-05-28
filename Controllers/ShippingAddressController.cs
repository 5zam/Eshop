using EcommerceDay1.Context;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceDay1.Controllers
{
    public class ShippingAddressController : Controller
    {
        private ApplicationDbContext _context;
        public ShippingAddressController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display()
        {
            return View();
        }
    }
}
