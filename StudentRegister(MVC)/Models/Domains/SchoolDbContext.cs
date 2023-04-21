using Microsoft.EntityFrameworkCore;
using StudentRegister_MVC_.Models.Domains.Entities;

namespace StudentRegister_MVC_.Models.Domains
{
    public class SchoolDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WIN-PFGV5N8DK24;Database=School;Trusted_Connection=True;");
        }
    }
}
