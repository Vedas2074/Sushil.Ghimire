using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.Database
{


    public class EMSContext : DbContext
    {
        public EMSContext()
        {
            
        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}