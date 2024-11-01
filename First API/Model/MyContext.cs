using First_API.Model;
using Microsoft.EntityFrameworkCore;

namespace First_API.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Employee> tbl_emp { get; set; }
    }
}
