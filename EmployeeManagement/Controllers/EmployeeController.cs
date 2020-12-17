using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Models;
using EmployeeManagement.Database;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private EMSContext db;

        public EmployeeController(EMSContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var employees = db.Employees.ToList();//fetch all the list ,linking database ,select query
            return View(employees);
        }
        public ActionResult Detail([FromQuery] int id)
        {
            var emp = db.Employees.Find(id);//executeone related to id
            return View(emp);

        }
        [HttpGet]//default always have [HttpGet] method
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add([FromForm] Employee employee)//controllers model binding
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));//nameof return the string version
        }
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employees)
        {
            db.Employees.Attach(employees);
            db.Employees.Update(employees);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(Employee employees)
        {
            db.Employees.Attach(employees);
            db.Employees.Remove(employees);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }

}