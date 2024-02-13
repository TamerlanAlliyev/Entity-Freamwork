using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;
using s=CodeFirst.Entities.Size;
using c=CodeFirst.Models.Entities;
using CodeFirst.Models.Entities;

namespace CodeFirst.Models.Context
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions options) :base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    string cString = "Server=DESKTOP-C3SM1NS\\SQLEXPRESS;Database=Ecommer;User Id=sa;Password=query;TrustServerCertificate=True;MultipleActiveResultSets=true;";
        //    optionsBuilder.UseSqlServer(cString);

        //}
        public DbSet<s.Size> Sizes { get; set; }
        public DbSet<c.Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
