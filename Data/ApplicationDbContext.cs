using BaiKiemTraKy072025.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTraKy072025.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
    
    }
}