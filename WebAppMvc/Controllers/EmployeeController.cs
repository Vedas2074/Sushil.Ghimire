using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee1= new Employee()
            {
                Id=1,
                FirstName="Sushil ",
                LastName="GHimire",
                Address="ktm",
                Age=12,
                Salary=12345.2345f
                
            };
            Employee employee2= new Employee()
            {
                Id=2,
                FirstName="Pendi ",
                LastName="Cholli",
                Address="lalit",
                Age=11,
                Salary=12345.2345f 
            };
            List<Employee> employees=new List<Employee>{employee1,employee2};
            return View(employees);
        }
        
    }
}