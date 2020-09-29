﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordPRO.Models;

namespace RecordPRO.Migrations
{
    [DbContext(typeof(RecordPROContext))]
    [Migration("20200522154134_CreateUserNote")]
    partial class CreateUserNote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
