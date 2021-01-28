using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DemoGraviton.Models
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration["ConnectionStrings:DefaultConnection"]);
        }

        public DbSet<Product> Products { get; set; }

    }
}
