﻿using Microsoft.EntityFrameworkCore;
using NAControle.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using NAControle.Infra.Data.Maps;

namespace NAControle.Infra.Data.Contexts
{
    public class EntityContext : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Grupo> Grupo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new GrupoMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("connectionString"));
        }
    }
}