using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccess
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-Q3JJ92I\\MSSQLSERVER01;database=CoreBlogApiDb; integrated security=true");
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
