using Microsoft.EntityFrameworkCore;
using NAControle.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NAControle.Infra.Data.Maps
{
    public class ServidorMap : IEntityTypeConfiguration<Servidor>
    {
        public void Configure(EntityTypeBuilder<Servidor> builder)
        {
            builder.ToTable("Servidor");

            builder.Property(c => c.Id)
                    .HasColumnName("Id");

            builder.Property(c => c.Nome)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

            builder.Property(c => c.SobreNome)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

            builder.Property(c => c.SobreNome)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

            builder.Property(c => c.Descricao)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Telefone)
                   .IsRequired()
                   .HasColumnType("VARCHAR(30)");

            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasColumnType("VARCHAR(30)");
        }
    }
}
