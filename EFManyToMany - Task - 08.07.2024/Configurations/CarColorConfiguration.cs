using EFManyToMany___Task___08._07._2024.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFManyToMany___Task___08._07._2024.Configurations;

public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
{
    public void Configure(EntityTypeBuilder<CarColor> builder)
    {
        builder.HasOne(x => x.Car).WithMany(x => x.CarColors);
        builder.HasOne(x => x.Color).WithMany(x => x.CarColors);
    }
}
