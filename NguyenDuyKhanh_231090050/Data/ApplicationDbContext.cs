using Microsoft.EntityFrameworkCore;
using NguyenDuyKhanh_2310900050.Models;
using System.Collections.Generic;

namespace NguyenDuyKhanh_2310900050.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<NdkEmployee> NdkEmployee { get; set; }
    }
}   