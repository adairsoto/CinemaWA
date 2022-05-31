﻿// <auto-generated />
using System;
using CinemaWA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaWA.Migrations
{
    [DbContext(typeof(CinemaWAContext))]
    partial class CinemaWAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CinemaWA.Models.Assento", b =>
                {
                    b.Property<int>("AssentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssentoId"), 1L, 1);

                    b.Property<string>("AssentoInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroAssento")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("AssentoId");

                    b.HasIndex("SalaId");

                    b.ToTable("Assento");
                });

            modelBuilder.Entity("CinemaWA.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClienteNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CinemaWA.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmeId"), 1L, 1);

                    b.Property<string>("Elenco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmeNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmeId");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("CinemaWA.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaId"), 1L, 1);

                    b.Property<int>("AssentoId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("SessaoId")
                        .HasColumnType("int");

                    b.HasKey("ReservaId");

                    b.HasIndex("AssentoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("SessaoId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("CinemaWA.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaId"), 1L, 1);

                    b.Property<string>("SalaNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalaId");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("CinemaWA.Models.Sessao", b =>
                {
                    b.Property<int>("SessaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessaoId"), 1L, 1);

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SessaoInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessaoNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sessaoinfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SessaoId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessao");
                });

            modelBuilder.Entity("CinemaWA.Models.Assento", b =>
                {
                    b.HasOne("CinemaWA.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("CinemaWA.Models.Reserva", b =>
                {
                    b.HasOne("CinemaWA.Models.Assento", "Assento")
                        .WithMany()
                        .HasForeignKey("AssentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWA.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWA.Models.Sessao", "Sessao")
                        .WithMany()
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assento");

                    b.Navigation("Cliente");

                    b.Navigation("Sessao");
                });

            modelBuilder.Entity("CinemaWA.Models.Sessao", b =>
                {
                    b.HasOne("CinemaWA.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWA.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filme");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}
