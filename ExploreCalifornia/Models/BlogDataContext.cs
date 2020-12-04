using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Models
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public IQueryable<MonthlySpecial> MonthlySpecials
        {
            get
            {
                return new[] 
                {
                    new MonthlySpecial {
                        Key = "calm",
                        Name = "California calm",
                        Type = "Day spa",
                        Price = 250
                    },
                    new MonthlySpecial {
                        Key = "Desert",
                        Name = "From Desert to Sea",
                        Type = "Day Salton",
                        Price = 350
                    }
                }.AsQueryable();
            }
        }

        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {            
            Database.EnsureCreated();
        }
    }
}