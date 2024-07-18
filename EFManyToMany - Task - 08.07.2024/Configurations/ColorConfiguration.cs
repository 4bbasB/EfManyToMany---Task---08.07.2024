using EFManyToMany___Task___08._07._2024.Models;
using Microsoft.EntityFrameworkCore;

namespace EFManyToMany___Task___08._07._2024.Configurations;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Color> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}
