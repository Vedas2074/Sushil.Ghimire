using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Department
    {
        [Key]
        public int ItemId { get; set; }
        [Required(ErrorMessage="Enter the Item Name")]
        
        public string ItemName { get; set; }
        [Required(ErrorMessage = "Enter the Item Price")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Mark the Item staus")]
        public bool Status { get; set; }
        public int Quantity { get; set; }

        public static List<Department> GetDepertments()

        {
            Department items1 = new Department()
            {
                ItemId = 101,
                ItemName = "Fan",
                Price = 2999.99f,
                Status = true,
                Quantity = 20
            };
            Department items2 = new Department()
            {

                ItemId = 102,
                ItemName = "Refrigerator",
                Price = 15999.99f,
                Status = true,
                Quantity = 10
            };
            Department items3 = new Department()
            {

                ItemId = 103,
                ItemName = "Smart Watch",
                Price = 999.99f,
                Status = false,
                Quantity = 30
            };
            List<Department> departments = new List<Department> { items1, items2, items3 };
            return departments;
        }
    }

}