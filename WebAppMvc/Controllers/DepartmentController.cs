using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
namespace DepartmentEmpManagement.Controllers
{
    public class DepartmentController :Controller
    {
        public IActionResult Index()
        {
            Department items1= new Department()
            {
                ItemId=101,
                ItemName="Fan",
                Price=2999.99f,
                Status=true,
                Quantity=20
            };
            Department items2= new Department()
            {
            
                ItemId=102,
                ItemName="Refrigerator",
                Price=15999.99f,
                Status=true,
                Quantity=10
            };
            Department items3= new Department()
            {
                
                ItemId=103,
                ItemName="Smart Watch",
                Price=999.99f,
                Status=false,
                Quantity=30
            };
            List<Department> departments= new List<Department>{items1,items2,items3};
            return View(departments);
        }
    }
}
