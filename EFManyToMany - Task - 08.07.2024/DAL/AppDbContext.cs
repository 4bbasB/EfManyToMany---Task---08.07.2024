using EFManyToMany___Task___08._07._2024.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFManyToMany___Task___08._07._2024.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarColor> CarColors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ABBAS\\SQLEXPRESS;Database=CarShopDb;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
