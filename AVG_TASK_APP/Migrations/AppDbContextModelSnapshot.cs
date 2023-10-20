﻿// <auto-generated />
using System;
using AVG_TASK_APP.Migration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AVG_TASK_APP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AVG_TASK_APP.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id_Table")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Table");

                    b.ToTable("Cards", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id_Task")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Task");

                    b.HasIndex("Id_User");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.MiniTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_Task")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("Id_Task");

                    b.ToTable("Mini Tasks", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Notify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<int>("Pin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("Id_User");

                    b.ToTable("Notifies", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id_Workspace")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Pin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("Visible")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("Id_Workspace");

                    b.ToTable("Tables", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Activity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Estimate")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Id_Card")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Card");

                    b.ToTable("Task", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_Table")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Table");

                    b.HasIndex("Id_User");

                    b.ToTable("User Tables", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_Task")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Task");

                    b.HasIndex("Id_User");

                    b.ToTable("User Tasks", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserWorkspace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<int>("Id_Workspace")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Id_User");

                    b.HasIndex("Id_Workspace");

                    b.ToTable("User Workspaces", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Workspace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Visible")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.ToTable("Workspaces", (string)null);
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Card", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Table", "Table")
                        .WithMany("cards")
                        .HasForeignKey("Id_Table")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Comment", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Task", "Task")
                        .WithMany("comments")
                        .HasForeignKey("Id_Task")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AVG_TASK_APP.Models.UserModel", "User")
                        .WithMany("comments")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.MiniTask", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Task", "Task")
                        .WithMany("miniTasks")
                        .HasForeignKey("Id_Task")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Notify", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.UserModel", "User")
                        .WithMany("notifies")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Table", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Workspace", "Workspace")
                        .WithMany("tables")
                        .HasForeignKey("Id_Workspace")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Task", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Card", "Card")
                        .WithMany("tasks")
                        .HasForeignKey("Id_Card")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserTable", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Table", "Table")
                        .WithMany("userTables")
                        .HasForeignKey("Id_Table")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AVG_TASK_APP.Models.UserModel", "User")
                        .WithMany("userTables")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserTask", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.Task", "Task")
                        .WithMany("userTasks")
                        .HasForeignKey("Id_Task")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AVG_TASK_APP.Models.UserModel", "User")
                        .WithMany("userTasks")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserWorkspace", b =>
                {
                    b.HasOne("AVG_TASK_APP.Models.UserModel", "User")
                        .WithMany("userWorkspaces")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AVG_TASK_APP.Models.Workspace", "Workspace")
                        .WithMany("userWorkspaces")
                        .HasForeignKey("Id_Workspace")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Card", b =>
                {
                    b.Navigation("tasks");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Table", b =>
                {
                    b.Navigation("cards");

                    b.Navigation("userTables");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Task", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("miniTasks");

                    b.Navigation("userTasks");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.UserModel", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("notifies");

                    b.Navigation("userTables");

                    b.Navigation("userTasks");

                    b.Navigation("userWorkspaces");
                });

            modelBuilder.Entity("AVG_TASK_APP.Models.Workspace", b =>
                {
                    b.Navigation("tables");

                    b.Navigation("userWorkspaces");
                });
#pragma warning restore 612, 618
        }
    }
}
