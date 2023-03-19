﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tickets.DAL;

#nullable disable

namespace Tickets.DAL.Migrations
{
    [DbContext(typeof(TicketsContext))]
    [Migration("20230318042659_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeveloperTicket", b =>
                {
                    b.Property<int>("DevelopersId")
                        .HasColumnType("int");

                    b.Property<int>("TicketsId")
                        .HasColumnType("int");

                    b.HasKey("DevelopersId", "TicketsId");

                    b.HasIndex("TicketsId");

                    b.ToTable("DeveloperTicket");
                });

            modelBuilder.Entity("Tickets.DAL.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jessie"
                        },
                        new
                        {
                            Id = 2,
                            Name = "heba"
                        },
                        new
                        {
                            Id = 3,
                            Name = "alaa"
                        },
                        new
                        {
                            Id = 4,
                            Name = "noor"
                        },
                        new
                        {
                            Id = 5,
                            Name = "yas"
                        });
                });

            modelBuilder.Entity("Tickets.DAL.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Diabetes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hypertension"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Asthma"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Depression"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Arthritis"
                        });
                });

            modelBuilder.Entity("Tickets.DAL.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Title = "Dana"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Title = "Isaac"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 1,
                            Title = "Damon"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 3,
                            Title = "Miriam"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 4,
                            Title = "Terence"
                        });
                });

            modelBuilder.Entity("DeveloperTicket", b =>
                {
                    b.HasOne("Tickets.DAL.Developer", null)
                        .WithMany()
                        .HasForeignKey("DevelopersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets.DAL.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tickets.DAL.Ticket", b =>
                {
                    b.HasOne("Tickets.DAL.Department", "Department")
                        .WithMany("Tickets")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Tickets.DAL.Department", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}