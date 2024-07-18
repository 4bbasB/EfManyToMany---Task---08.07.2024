using EFManyToMany___Task___08._07._2024.Models;
using Microsoft.EntityFrameworkCore;

namespace EFManyToMany___Task___08._07._2024.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Car> builder)
    {
        builder.Property(x => x.Power)
            .IsRequired()
            .HasColumnType("INT");

        builder.Property(x => x.DoorCount)
            .IsRequired()
            .HasColumnType("INT");

        builder.Property(x => x.FuelTankCapacity)
            .IsRequired()
            .HasColumnType("INT");

        builder.Property(x => x.MaxSpeed)
            .IsRequired()
            .HasColumnType("INT");

        builder.HasKey(x => x.ModelId);
    }
}
