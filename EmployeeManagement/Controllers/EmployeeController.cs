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
        public ActionResult Detail(int id)
        {
            var employees = Employee.GetEmployee();
            var emp = employees.Where(x => x.Id == id).FirstOrDefault();
            return View(emp);

        }
        public IActionResult Add()
        {
            return View();
        }
    }

}