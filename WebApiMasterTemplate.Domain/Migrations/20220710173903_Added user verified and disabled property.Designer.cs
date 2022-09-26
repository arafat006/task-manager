﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiMasterTemplate.Domain.DbContexts;

#nullable disable

namespace WebApiMasterTemplate.Domain.Migrations
{
    [DbContext(typeof(TaskPlannerDbContext))]
    [Migration("20220710173903_Added user verified and disabled property")]
    partial class Addeduserverifiedanddisabledproperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.TaskKeeper", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<long>("TaskTrackerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("TaskTrackerId");

                    b.ToTable("Task", (string)null);
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.TaskTracker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("TaskTracker", (string)null);
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDisabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("Role")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.TaskKeeper", b =>
                {
                    b.HasOne("WebApiMasterTemplate.Domain.DbModels.TaskTracker", "TaskTracker")
                        .WithMany("TaskKeepers")
                        .HasForeignKey("TaskTrackerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskTracker");
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.TaskTracker", b =>
                {
                    b.HasOne("WebApiMasterTemplate.Domain.DbModels.User", "User")
                        .WithMany("TaskTrackers")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.UserRole", b =>
                {
                    b.HasOne("WebApiMasterTemplate.Domain.DbModels.User", "User")
                        .WithOne("UserRole")
                        .HasForeignKey("WebApiMasterTemplate.Domain.DbModels.UserRole", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.TaskTracker", b =>
                {
                    b.Navigation("TaskKeepers");
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.User", b =>
                {
                    b.Navigation("TaskTrackers");

                    b.Navigation("UserRole")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}