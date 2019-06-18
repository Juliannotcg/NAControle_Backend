using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NAControle.Domain.Models;

namespace NAControle.Infra.Data.Maps
{
    class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupo");

            builder.Property(c => c.Id)
                    .HasColumnName("Id");

            builder.Property(c => c.Nome)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");
        }
    }
}
