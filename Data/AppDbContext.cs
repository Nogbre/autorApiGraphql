using AutoresAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoresAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
    }
}
