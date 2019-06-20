using Microsoft.EntityFrameworkCore;
using NAControle.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NAControle.Infra.Data.Maps
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.Property(c => c.Id)
                    .HasColumnName("Id");

            builder.Property(c => c.Logradouro)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Lote)
                    .IsRequired()
                    .HasColumnType("INT");

            builder.Property(c => c.Rua)
                    .IsRequired()
                    .HasColumnType("INT");

            builder.Property(c => c.Quadra)
                   .IsRequired()
                   .HasColumnType("INT");

            builder.Property(c => c.Cidade)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Cep)
                   .IsRequired()
                   .HasColumnType("INT");

            builder.Property(c => c.Latitude)
                  .IsRequired()
                  .HasColumnType("VARCHAR(30)");

            builder.Property(c => c.Longitude)
                  .IsRequired()
                  .HasColumnType("VARCHAR(30)");
        }
    }
}
