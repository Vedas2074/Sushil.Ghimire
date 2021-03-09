using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Database;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private EMSContext db;

        public DepartmentController(EMSContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var department = db.Departments.ToList();
            return View(department);

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm] Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult details([FromQuery] int id)
        {
            var dept = db.Departments.Find(id);
            return View(dept);
        }
        public IActionResult Edit([FromQuery] int id)
        {
            var dept = db.Departments.Find(id);
            return View(dept);

        }
        [HttpPost]
        public IActionResult Edit([FromForm] Department department)
        {
            db.Departments.Attach(department);
            db.Departments.Update(department);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var dept = db.Departments.Find(id);
            return View(dept);
        }
        [HttpPost]
        public IActionResult Delete([FromForm] Department department)
        {
            db.Departments.Attach(department);
            db.Departments.Remove(department);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
