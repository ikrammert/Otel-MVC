using Microsoft.AspNetCore.Mvc;
using Otel_MVC.Models;

namespace Otel_MVC.Controllers
{
    public class HotelController : Controller
    {
        private readonly RepositoryContext _context;

        public HotelController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        { //Show all hotels
            var model = _context.Hotels.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Hotel model)
        {
            if (ModelState.IsValid)
            {
                // model.CreateAt = DateTime.Now;
                _context.Hotels.Add(model);
                _context.SaveChangesAsync();
                return View("Feedback", model);
            }
            return View();
        }

        public IActionResult Get(int id)
        {
            Hotel hotel = _context.Hotels.First(p => p.HotelId == id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult DeleteSelected([FromForm] int[] selectedIds){
        //     if (selectedIds == null || selectedIds.Length == 0){
        //         return RedirectToAction("Index");
        //     }
        //     try{
        //         foreach (var id in selectedIds){
        //             var hotel = _context.Hotels.Find(id);
        //             if (hotel != null){
        //                 _context.Hotels.Remove(hotel);
        //             }
        //         }
        //         _context.SaveChanges();
        //         return RedirectToAction("Index");
        //     }
        //     catch (Exception ex){
        //         return RedirectToAction("Index");
        //     }
        // }
    }
}
