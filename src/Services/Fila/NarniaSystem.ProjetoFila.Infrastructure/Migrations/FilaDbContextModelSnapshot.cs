﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NarniaSystem.ProjetoFila.Infrastructure.Data;

#nullable disable

namespace NarniaSystem.ProjetoFila.Infrastructure.Migrations
{
    [DbContext(typeof(FilaDbContext))]
    partial class FilaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Categorias.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AlteredAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("NivelPrioridadeEnum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Estabelecimentos.Estabelecimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AlteredAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Estabelecimento");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Filas.Fila", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AlteredAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TelaId")
                        .HasColumnType("int");

                    b.Property<Guid>("TelaId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TelaId1");

                    b.ToTable("Fila");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Guiches.Guiche", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AlteredAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.HasKey("Id");

                    b.ToTable("Guiche");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Senhas.Senha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AlteredAt")
                        .HasColumnType("DATETIME");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoriaId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId1");

                    b.ToTable("Senhas");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Telas.Tela", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AlteredAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("EstabelecimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EstabelecimentoId");

                    b.ToTable("Tela");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Filas.Fila", b =>
                {
                    b.HasOne("NarniaSystem.ProjetoFila.Domain.Entities.Telas.Tela", "Tela")
                        .WithMany("Filas")
                        .HasForeignKey("TelaId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tela");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Senhas.Senha", b =>
                {
                    b.HasOne("NarniaSystem.ProjetoFila.Domain.Entities.Categorias.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Telas.Tela", b =>
                {
                    b.HasOne("NarniaSystem.ProjetoFila.Domain.Entities.Estabelecimentos.Estabelecimento", "Estabelecimento")
                        .WithMany()
                        .HasForeignKey("EstabelecimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estabelecimento");
                });

            modelBuilder.Entity("NarniaSystem.ProjetoFila.Domain.Entities.Telas.Tela", b =>
                {
                    b.Navigation("Filas");
                });
#pragma warning restore 612, 618
        }
    }
}
