using MarketShop.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketShop.Web.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User>? Users { get; set; }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<City>? Cities { get; set; }
    }
}