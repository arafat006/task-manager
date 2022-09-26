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
    [Migration("20220528191044_Initial")]
    partial class Initial
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

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 5, DateTimeKind.Utc).AddTicks(744),
                            Email = "JerroldBeahan79@gmail.com",
                            Name = "Jerrold Beahan",
                            Password = "_hpGqGPhzktEtjKHmIOHezxWJ1aTfHU3VjACspwC6okiTo_hU9b7RZb1x3GulFbTZqKtr4tS6EUaJ_IpdCM8M4Xo7xljSLvSyqtnXt7hUenBX7L4bR4kzngF_E9WlVBP"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 5, DateTimeKind.Utc).AddTicks(1375),
                            Email = "CarolinaOrn9@hotmail.com",
                            Name = "Carolina Orn",
                            Password = "Pa_iYCzV14uv111OPwxFTrfg1T7p5jvERDVe8TNlAvntmAd_8CTaPlnMX_Dyn4Fn5QkcWckEfpa8UB1gNd4XAIHa9XMGEUgfAr4jkV4KqiSY_mYZGNNJWKOURgnTH2Et"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(5571),
                            Email = "MoniqueOConnell66@yahoo.com",
                            Name = "Monique O'Connell",
                            Password = "jv3v6_ZKZumKESDHl3K7xHxATonW6o9okL2KRfPY6QTe67XmIqLj7pR406J7q83ptUsvl_YXFMnXypiVA0mpIxjDALQz7O6dgODLg1rOBieGpRXkonx54NmbUt8UqKCq"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(6593),
                            Email = "BrantOndricka94@gmail.com",
                            Name = "Brant Ondricka",
                            Password = "uvwr5J5IadaQmpTWIVZ1EB5b7aimjrkJaGtTP9xBUqUFSItehoRuaHrrp2TpDHAHgtPpLZrS9imVr8IP1wLx09DcnvZ0sWWmYNLTeIn3_5LnUkBBIBeHB20u89AwDxoO"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(7587),
                            Email = "WymanCummings26@gmail.com",
                            Name = "Wyman Cummings",
                            Password = "EYkgabakx7cljiRbaMw3B0SP6UazIIWmlsrIZhqTk_FdS4wwZakmzYmqHb8nVcL3jrtaf0MjkaiQqIBq60mEA4axuymrNeyKEItB7JurkNpxohDRikCW1ntP1MZsB3WD"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(8641),
                            Email = "VenaPouros_Gerhold@hotmail.com",
                            Name = "Vena Pouros",
                            Password = "F_nNec2j8Z5hIRTmEfm2SmGatgo1FztMu2Bp14TVJydo8kWxIoGkohGzpLGGBRbEnBliHgkBCwS_g3xtY6Lvg3xoaNcO9pGYHMisXuabJ3AWPNUrqWMbUKL23uHxD2yu"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(9639),
                            Email = "EstaBerge85@hotmail.com",
                            Name = "Esta Berge",
                            Password = "PRpDLSfA4OH0JhDXZJcndDyefEcY1M4hDWy_HhGqZntoa04Ylz9YMGj9wp8dzDslFN8CVHojQlWkOX6YuP8gIbIJY0XAsa9NkjzDDxZI6Lx4iHIymQtWV4c1UiA8Ebve"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 7, DateTimeKind.Utc).AddTicks(615),
                            Email = "CarmelaMorissette83@yahoo.com",
                            Name = "Carmela Morissette",
                            Password = "5Z1teqibHPhjMknFkFdMYtyaALdYO4fZCHr1P_b8gdWVG6QKcfgB5cIG2a655zVRq_vBUJ6Pq7F3XnauDAZja95keqeVzTh3CQFciFn9X8GgAPhuPrW0MYKEkb0n574G"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 7, DateTimeKind.Utc).AddTicks(1660),
                            Email = "StephenLynch95@yahoo.com",
                            Name = "Stephen Lynch",
                            Password = "cRVUSzX7SdAdYaWRXIQJzDlk43GCN_l89fReZvS2dBih8JCyGl8VjGZa3UsunWBLItTJCCM9BYXz4RPXyqleNxEyRtS2G44SefcQIofn0U4V4LSra6hj7HFre9Tg6FQY"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedDate = new DateTime(2022, 5, 28, 19, 10, 44, 7, DateTimeKind.Utc).AddTicks(2747),
                            Email = "VioletteKozey.Johnson95@gmail.com",
                            Name = "Violette Kozey",
                            Password = "1w1JWbSFD9OYg0NQ37qg7czGM6Hqz29PiMBrRS92FXQW80n6JychHKlcPCsST9gJ3cM3veIST26yXzXRhh4FBGXj6c1FbUfrU_tO43neE9SeeY38H7Lgl5f43Lqd5VU_"
                        });
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

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.TaskTracker", b =>
                {
                    b.Navigation("TaskKeepers");
                });

            modelBuilder.Entity("WebApiMasterTemplate.Domain.DbModels.User", b =>
                {
                    b.Navigation("TaskTrackers");
                });
#pragma warning restore 612, 618
        }
    }
}
