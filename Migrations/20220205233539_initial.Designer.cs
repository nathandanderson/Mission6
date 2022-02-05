﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20220205233539_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission6.Models.TasksResponse", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = 2,
                            Completed = false,
                            DueDate = "02/09/22",
                            Quadrant = 1,
                            TaskName = "Mission6 Assignment"
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = 1,
                            Completed = false,
                            DueDate = "02/12/22",
                            Quadrant = 3,
                            TaskName = "Laundry"
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = 1,
                            Completed = false,
                            DueDate = "None",
                            Quadrant = 4,
                            TaskName = "Respond to emails"
                        },
                        new
                        {
                            TaskID = 4,
                            CategoryID = 4,
                            Completed = false,
                            DueDate = "None",
                            Quadrant = 2,
                            TaskName = "Relationship Building"
                        });
                });

            modelBuilder.Entity("Mission6.Models.TasksResponse", b =>
                {
                    b.HasOne("Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
