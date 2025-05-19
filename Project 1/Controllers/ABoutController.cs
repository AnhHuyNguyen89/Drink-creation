using Microsoft.AspNetCore.Mvc;
using Project_1.Models;

namespace Project_1.Controllers
{
    public class ABoutController : Controller
    {
        private static List<StoreViewModel> stores = new List<StoreViewModel>();
        public IActionResult Index()
        {
           return View(stores);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateDrink(StoreViewModel storeViewModel)
        {
            //return View("Index");
            stores.Add(storeViewModel); 
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "About us";
        }
    }
}
