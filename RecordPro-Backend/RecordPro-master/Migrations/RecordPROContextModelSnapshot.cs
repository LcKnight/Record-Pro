﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordPRO.Models;

namespace RecordPRO.Migrations
{
    [DbContext(typeof(RecordPROContext))]
    partial class RecordPROContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RecordPRO.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Token")
                        .HasColumnType("varchar(200)");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RecordPRO.Models.UserBill", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("amount")
                        .HasColumnType("float");

                    b.Property<string>("category")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("datetime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("type")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UserBill");
                });

            modelBuilder.Entity("RecordPRO.Models.UserBody", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("bust")
                        .HasColumnType("float");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("height")
                        .HasColumnType("float");

                    b.Property<float>("hips")
                        .HasColumnType("float");

                    b.Property<float>("shoulder")
                        .HasColumnType("float");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<float>("waist")
                        .HasColumnType("float");

                    b.Property<float>("weight")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("UserBody");
                });

            modelBuilder.Entity("RecordPRO.Models.UserFace", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("beauty")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("datetime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("emotion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("facetoken")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("filepath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("skinstatus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("smile")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UserFace");
                });

            modelBuilder.Entity("RecordPRO.Models.UserMemorial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("desc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UserMemorial");
                });

            modelBuilder.Entity("RecordPRO.Models.UserNote", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("sentiment")
                        .HasColumnType("int");

                    b.Property<string>("tags")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<int>("wordcount")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UserNote");
                });
#pragma warning restore 612, 618
        }
    }
}