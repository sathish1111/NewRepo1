using Microsoft.AspNetCore.Mvc;
using TESTSIX.Models;
using TESTSIX.Repository.IRepository;

namespace TESTSIX.Controllers
{
    public class CoverTypeController : Controller
    {
        private readonly IUnitofWork _db;
        public CoverTypeController(IUnitofWork db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CoverType> objlist = _db.coverType.GetAll();


            return View(objlist);
        }


        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoverType cr)
        {


            

            if (ModelState.IsValid)
            {
                _db.coverType.Add(cr);
                _db.save();
                TempData["success"] = "Created Successfully";
                return RedirectToAction("Index");
            }
            return View(cr);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CoverType = _db.coverType.GetOrDeafault(u => u.Id == id);

            if (CoverType == null)
            {
                return NotFound();

            }
            return View(CoverType);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType cr)
        {


            

            if (ModelState.IsValid)
            {
                _db.coverType.Update(cr);
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
            var coverType = _db.coverType.GetOrDeafault(u => u.Id == id);

            if (coverType == null)
            {
                return NotFound();
            }

            _db.coverType.Remove(coverType);
            _db.save();
            TempData["success"] = "Remove  Successfully";
            return RedirectToAction("Index");

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CoverType cr)
        {


            if (ModelState.IsValid)
            {
                _db.coverType.Update(cr);
                _db.save();

                return RedirectToAction("Index");
            }
            return View(cr);
        }

    }
}
