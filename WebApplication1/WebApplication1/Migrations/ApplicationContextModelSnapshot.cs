﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CD");

                    b.Property<string>("Name");

                    b.Property<long?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WebApplication1.Models.Root", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BodyFlag1");

                    b.Property<string>("BodyFlag2");

                    b.Property<bool>("IsAdmin");

                    b.HasKey("Id");

                    b.ToTable("Roots");
                });

            modelBuilder.Entity("WebApplication1.Models.ThanksCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<long>("CD");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<long>("Date");

                    b.Property<bool>("Flag1");

                    b.Property<bool>("Flag2");

                    b.Property<long>("FromId");

                    b.Property<string>("Title");

                    b.Property<long>("ToId");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("ThanksCards");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CD");

                    b.Property<long?>("DepartmentId");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int?>("RootId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RootId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.HasOne("WebApplication1.Models.Department", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("WebApplication1.Models.ThanksCard", b =>
                {
                    b.HasOne("WebApplication1.Models.User", "From")
                        .WithMany()
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.User", "To")
                        .WithMany()
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.HasOne("WebApplication1.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("WebApplication1.Models.Root", "Root")
                        .WithMany()
                        .HasForeignKey("RootId");
                });
#pragma warning restore 612, 618
        }
    }
}
