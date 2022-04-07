using Microsoft.EntityFrameworkCore;
using RestApiCRUDDemo.Models;

namespace RestApiCRUDDemo.EmployeeDbContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> emp1 { get; set; }
    }
   
}
