using Microsoft.AspNetCore.Mvc;
using TESTSIX.Data;
using TESTSIX.Models;
using TESTSIX.Repository.IRepository;

namespace TESTSIX.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitofWork _db;
        public CategoryController(IUnitofWork db) {
        _db= db;
        }

        public IActionResult Index()
        {
         IEnumerable<Category> objlist =_db.categoty.GetAll();


            return View(objlist);
        }


        public IActionResult Create()
        {
            
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category cr )
        {
            

            if (cr.Name.ToString() == cr.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name order Not Matched");
            }

            if (ModelState.IsValid)
            {
                _db.categoty.Add(cr);
                _db.save();
                TempData["success"] = "Created Successfully";
                return RedirectToAction("Index");
            }
            return View(cr);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id==0) 
            {
                return NotFound();            
            }
            var category = _db.categoty.GetOrDeafault(u=>u.Id== id);

            if (category == null)
            {
                return NotFound();

            }
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category cr)
        {


            if (cr.Name.ToString() == cr.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name order Not Matched");
            }

            if (ModelState.IsValid)
            {
                _db.categoty.Update(cr);
                _db.save();

                TempData["success"] = "Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(cr);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _db.categoty.GetOrDeafault(u => u.Id == id);

            if (category == null )
            {
                return NotFound();
            }

            _db.categoty.Remove(category);
            _db.save();
            TempData["success"] = "Remove  Successfully";
            return RedirectToAction("Index");
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category cr)
        {


            if (cr.Name.ToString() == cr.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name order Not Matched");
            }

            if (ModelState.IsValid)
            {
                _db.categoty.Update(cr);
                _db.save();

                return RedirectToAction("Index");
            }
            return View(cr);
        }

    }
}
