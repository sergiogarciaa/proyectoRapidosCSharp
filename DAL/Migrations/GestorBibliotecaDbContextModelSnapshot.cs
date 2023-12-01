﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(GestorBibliotecaDbContext))]
    partial class GestorBibliotecaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Modelos.Usuarios", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_usuario"));

                    b.Property<string>("apellidos_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("clave_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dni_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("fch_alta_usuario")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nombre_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("tlf_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_usuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            id_usuario = 1,
                            apellidos_usuario = "ADMIN",
                            clave_usuario = "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270",
                            dni_usuario = "1",
                            email_usuario = "admin@gmail.com",
                            fch_alta_usuario = new DateTime(2023, 11, 30, 12, 4, 52, 485, DateTimeKind.Utc).AddTicks(2033),
                            nombre_usuario = "ADMIN",
                            tlf_usuario = "1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
