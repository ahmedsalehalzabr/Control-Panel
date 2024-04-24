using Control_Panel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Control_Panel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) 
        {
            
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
