using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = Employee.GetEmployee();
            return View(employees);
        }
        public ActionResult Detail([FromQuery] int id)
        {
            var employees = Employee.GetEmployee();
            var emp = employees.Where(x => x.Id == id).FirstOrDefault();
            return View(emp);

        }
        [HttpGet]//default always have [HttpGet] method
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<string> Add([FromForm] Employee employee)//controllers model binding
        {
            return "save record";
        }
    }

}