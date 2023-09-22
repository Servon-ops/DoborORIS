using Microsoft.EntityFrameworkCore;
using WEBORIS.Models;

namespace WEBORIS.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }

    }
}
