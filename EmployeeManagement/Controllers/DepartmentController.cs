using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            var department = Department.GetDepertments();

            return View(department);

        }
        public ActionResult details(int id)
        {
            var department = Department.GetDepertments();
            var dept = department.Where(x => x.ItemId == id).FirstOrDefault();

            return View(dept);
        }
    }
}
