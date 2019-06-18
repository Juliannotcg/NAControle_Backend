using Microsoft.EntityFrameworkCore;
using NAControle.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NAControle.Infra.Data.Maps
{
    public class ReuniaoMap : IEntityTypeConfiguration<Reuniao>
    {
        public void Configure(EntityTypeBuilder<Reuniao> builder)
        {
            builder.ToTable("Reuniao");

            builder.Property(c => c.Id)
                    .HasColumnName("Id");

            builder.Property(c => c.Dia)
                    .IsRequired()
                    .HasColumnType("DATETIME");

            builder.Property(c => c.HoraInicio)
                   .IsRequired()
                   .HasColumnType("DATETIME");

            builder.Property(c => c.HoraFim)
                   .IsRequired()
                   .HasColumnType("DATETIME");

            builder.Property(c => c.Aberta)
                   .IsRequired()
                   .HasColumnType("BIT");

            builder.Property(c => c.Ativa)
                  .IsRequired()
                  .HasColumnType("BIT");
        }
    }
}
