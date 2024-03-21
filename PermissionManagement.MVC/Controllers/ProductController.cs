using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PermissionManagement.MVC.Constants;
using PermissionManagement.MVC.Data;

namespace PermissionManagement.MVC.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Policy = Permissions.Products.View)]
        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }
    }
}