using Microsoft.AspNetCore.Mvc;
using Otel_MVC.Models;

namespace Otel_MVC.Controllers
{
    public class HotelController : Controller
    {
        private readonly RepositoryContext _context;

        public HotelController(RepositoryContext context){
            _context = context;
        }

        public IActionResult Index(){ //Show all hotels
            var model = _context.Hotels.ToList();
            return View(model);
        }

        public IActionResult Create(){
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Hotel model){
            // model.CreateAt = DateTime.Now;
            model.IsActive = true;
            if (ModelState.IsValid)
            {
            _context.Hotels.Add(model);
            return View("Feedback",model);
            }
            return View();
        }


    }
}
