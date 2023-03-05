using Microsoft.AspNetCore.Mvc;
using MVC_Uygulama_Guncel.Models;

namespace MVC_Uygulama_Guncel.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ProjectContext _contex;
        public EmployeeController(ProjectContext contex)
        {
            _contex = contex;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Employee employee)
        {
            return View(employee);
        }
        
        public IActionResult Listele()
        {

            return View();
        }
        public IActionResult duzenle(int id)
        {
            return View();
        }
        public IActionResult Delete(int id) 
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
