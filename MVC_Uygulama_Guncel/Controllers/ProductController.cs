using Microsoft.AspNetCore.Mvc;
using MVC_Uygulama_Guncel.Models;

namespace MVC_Uygulama_Guncel.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProjectContext _context;
        public ProductController(ProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ekle(Product model)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(model);

                _context.SaveChanges();

                return RedirectToAction("Listele");
            }
            return View(model);
        }
        public IActionResult Listele()
        {

            return View(_context.Products.ToList());
        }
        public IActionResult Duzenle(int id)
        {
            return View(_context.Products.Find(id));
        }
        [HttpPost]
        public IActionResult Duzenle(Product model)
        {
            _context.Products.Update(model);
            _context.SaveChanges();

            return RedirectToAction("Listele");
        }
        public IActionResult detay(int id) => View(_context.Products.Find(id));

        public IActionResult Sil(Product model)
        {
            _context.Products.Remove(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Listele));
        }
    }
}
