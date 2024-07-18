using EFManyToMany___Task___08._07._2024.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFManyToMany___Task___08._07._2024.Configurations;

public class BrandConiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Id)
            .IsRequired()
            .HasColumnType("INT");

    }
}
