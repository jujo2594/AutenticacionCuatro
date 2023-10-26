﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(AutenticacionContext))]
    [Migration("20231026175359_migration1")]
    partial class migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdDepartamentoFk")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("Ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdPaisFk")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("longtext");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("LetraSec")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("NumeroViaSec")
                        .HasColumnType("int");

                    b.Property<string>("PersonasId")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SufijoCardinal")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("SufijoCardinalSec")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("TipoVia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("PersonasId");

                    b.ToTable("Direccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreGenero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genero", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("IdSalonFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdSalonFk");

                    b.ToTable("Matricula", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IdCiudadFk")
                        .HasColumnType("varchar(3)");

                    b.Property<int>("IdGeneroFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdGeneroFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Salon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreSalon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Salon", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TrainerSalon", b =>
                {
                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("IdSalonFk")
                        .HasColumnType("int");

                    b.HasKey("IdPersonaFk", "IdSalonFk");

                    b.HasIndex("IdSalonFk");

                    b.ToTable("TrainerSalon", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk");

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk");

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany()
                        .HasForeignKey("PersonasId");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Matricula", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("Matriculas")
                        .HasForeignKey("IdPersonaFk");

                    b.HasOne("Domain.Entities.Salon", "Salones")
                        .WithMany("Matriculas")
                        .HasForeignKey("IdSalonFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("Salones");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudades")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudadFk");

                    b.HasOne("Domain.Entities.Genero", "Generos")
                        .WithMany("Personas")
                        .HasForeignKey("IdGeneroFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoPersona", "TipoPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");

                    b.Navigation("Generos");

                    b.Navigation("TipoPersonas");
                });

            modelBuilder.Entity("Domain.Entities.TrainerSalon", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Salon", "Salones")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("IdSalonFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("Salones");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Genero", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Domain.Entities.Salon", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
