using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }
        public float Salary { get; set; }


        public static List<Employee> GetEmployee()
        {
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Sushil ",
                LastName = "Ghimire",
                Address = "ktm",
                Age = 12,
                Salary = 12345.2345f

            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Prakash ",
                LastName = "Tamang",
                Address = "lalitpur",
                Age = 11,
                Salary = 12345.2345f
            };
            List<Employee> employees = new List<Employee> { employee1, employee2 };
            return employees;
        }
    }
}

