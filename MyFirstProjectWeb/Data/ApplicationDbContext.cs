using Microsoft.EntityFrameworkCore;
using MyFirstProjectWeb.Models;

namespace MyFirstProjectWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
