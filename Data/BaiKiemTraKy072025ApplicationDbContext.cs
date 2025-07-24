using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiKiemTraKy072025.Models;

    public class BaiKiemTraKy072025ApplicationDbContext : DbContext
    {
        public BaiKiemTraKy072025ApplicationDbContext (DbContextOptions<BaiKiemTraKy072025ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaiKiemTraKy072025.Models.Person> Person { get; set; } = default!;
    }
