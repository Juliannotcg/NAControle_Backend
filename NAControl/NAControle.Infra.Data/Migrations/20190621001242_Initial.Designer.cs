﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NAControle.Infra.Data.Contexts;

namespace NAControle.Infra.Data.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20190621001242_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NAControle.Domain.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("Cep")
                        .HasColumnType("INT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<int>("Lote")
                        .HasColumnType("INT");

                    b.Property<int>("Quadra")
                        .HasColumnType("INT");

                    b.Property<int>("Rua")
                        .HasColumnType("INT");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("NAControle.Domain.Models.Grupo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<Guid?>("EnderecoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("NAControle.Domain.Models.Reuniao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Aberta")
                        .HasColumnType("BIT");

                    b.Property<bool>("Ativa")
                        .HasColumnType("BIT");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("DATETIME");

                    b.Property<Guid?>("GrupoId");

                    b.Property<DateTime>("HoraFim")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("DATETIME");

                    b.Property<Guid?>("SecretarioId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("SecretarioId");

                    b.ToTable("Reuniao");
                });

            modelBuilder.Entity("NAControle.Domain.Models.Servidor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<Guid?>("EnderecoId");

                    b.Property<Guid?>("GrupoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("Servidor");
                });

            modelBuilder.Entity("NAControle.Domain.Models.Grupo", b =>
                {
                    b.HasOne("NAControle.Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("NAControle.Domain.Models.Reuniao", b =>
                {
                    b.HasOne("NAControle.Domain.Models.Grupo")
                        .WithMany("Reuniao")
                        .HasForeignKey("GrupoId");

                    b.HasOne("NAControle.Domain.Models.Servidor", "Secretario")
                        .WithMany()
                        .HasForeignKey("SecretarioId");
                });

            modelBuilder.Entity("NAControle.Domain.Models.Servidor", b =>
                {
                    b.HasOne("NAControle.Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("NAControle.Domain.Models.Grupo")
                        .WithMany("Servidor")
                        .HasForeignKey("GrupoId");
                });
#pragma warning restore 612, 618
        }
    }
}