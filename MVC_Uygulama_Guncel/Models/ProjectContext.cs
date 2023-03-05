using Microsoft.EntityFrameworkCore;

namespace MVC_Uygulama_Guncel.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
    }


}
