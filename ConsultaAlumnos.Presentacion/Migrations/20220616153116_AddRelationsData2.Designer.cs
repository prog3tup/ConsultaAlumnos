﻿// <auto-generated />
using System;
using InformacionCiudades.API.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsultaAlumnos.API.Migrations
{
    [DbContext(typeof(ConsultaAlumnosContext))]
    [Migration("20220616153116_AddRelationsData2")]
    partial class AddRelationsData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("AlumnoMateria", b =>
                {
                    b.Property<int>("AlumnosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MateriasEnCursoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlumnosId", "MateriasEnCursoId");

                    b.HasIndex("MateriasEnCursoId");

                    b.ToTable("AlumnoMateria", (string)null);

                    b.HasData(
                        new
                        {
                            AlumnosId = 1,
                            MateriasEnCursoId = 1
                        },
                        new
                        {
                            AlumnosId = 1,
                            MateriasEnCursoId = 2
                        });
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EstadoConsulta")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaFinalizacion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaUltimaModificacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdAlumnoCreador")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMateria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProfesor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdAlumnoCreador");

                    b.HasIndex("IdMateria");

                    b.HasIndex("IdProfesor");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cuatrimestre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Materias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cuatrimestre = "Tercer",
                            Nombre = "Programación 3"
                        },
                        new
                        {
                            Id = 2,
                            Cuatrimestre = "Tercer",
                            Nombre = "Programación 4"
                        });
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Respuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdConsulta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdCreador")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdConsulta");

                    b.HasIndex("IdCreador");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("MateriaProfesor", b =>
                {
                    b.Property<int>("MateriasAsignadasId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfesoresId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MateriasAsignadasId", "ProfesoresId");

                    b.HasIndex("ProfesoresId");

                    b.ToTable("MateriaProfesor");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Alumno", b =>
                {
                    b.HasBaseType("ConsultaAlumnos.API.Entities.Usuario");

                    b.HasDiscriminator().HasValue("Alumno");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Bologna",
                            Email = "nbologna31@gmail.com",
                            Nombre = "Nicolas",
                            NombreUsuario = "nbologna_alumno",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Perez",
                            Email = "Jperez@gmail.com",
                            Nombre = "Juan",
                            NombreUsuario = "jperez",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Garcia",
                            Email = "pgarcia@gmail.com",
                            Nombre = "Pedro",
                            NombreUsuario = "pgarcia",
                            Password = "123456"
                        });
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Profesor", b =>
                {
                    b.HasBaseType("ConsultaAlumnos.API.Entities.Usuario");

                    b.HasDiscriminator().HasValue("Profesor");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Apellido = "Bologna",
                            Email = "nbologna31@gmail.com",
                            Nombre = "Nicolas",
                            NombreUsuario = "nbologna_profesor",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 5,
                            Apellido = "Paez",
                            Email = "ppaez@gmail.com",
                            Nombre = "Pablo",
                            NombreUsuario = "ppaez",
                            Password = "123456"
                        });
                });

            modelBuilder.Entity("AlumnoMateria", b =>
                {
                    b.HasOne("ConsultaAlumnos.API.Entities.Alumno", null)
                        .WithMany()
                        .HasForeignKey("AlumnosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultaAlumnos.API.Entities.Materia", null)
                        .WithMany()
                        .HasForeignKey("MateriasEnCursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Consulta", b =>
                {
                    b.HasOne("ConsultaAlumnos.API.Entities.Alumno", "Alumno")
                        .WithMany("Consultas")
                        .HasForeignKey("IdAlumnoCreador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultaAlumnos.API.Entities.Materia", "Materia")
                        .WithMany("Consultas")
                        .HasForeignKey("IdMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultaAlumnos.API.Entities.Profesor", "ProfesorAsignado")
                        .WithMany("ConsultasAsignadas")
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Materia");

                    b.Navigation("ProfesorAsignado");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Respuesta", b =>
                {
                    b.HasOne("ConsultaAlumnos.API.Entities.Consulta", "Consulta")
                        .WithMany("Posts")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultaAlumnos.API.Entities.Usuario", "Creador")
                        .WithMany()
                        .HasForeignKey("IdCreador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("Creador");
                });

            modelBuilder.Entity("MateriaProfesor", b =>
                {
                    b.HasOne("ConsultaAlumnos.API.Entities.Materia", null)
                        .WithMany()
                        .HasForeignKey("MateriasAsignadasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultaAlumnos.API.Entities.Profesor", null)
                        .WithMany()
                        .HasForeignKey("ProfesoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Consulta", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Materia", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Alumno", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("ConsultaAlumnos.API.Entities.Profesor", b =>
                {
                    b.Navigation("ConsultasAsignadas");
                });
#pragma warning restore 612, 618
        }
    }
}
