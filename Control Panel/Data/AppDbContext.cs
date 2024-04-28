using Control_Panel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Control_Panel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CategoryIamge> CategoryIamges { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
    }
} 
