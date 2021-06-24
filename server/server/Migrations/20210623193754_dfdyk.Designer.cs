﻿// <auto-generated />
using System;
using ITIL_Lab_Test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210623193754_dfdyk")]
    partial class dfdyk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITIL_Lab_Test.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PoDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PoNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("RefId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ITIL_Lab_Test.Models.OrderDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ITIL_Lab_Test.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Product 1",
                            Rate = 102m
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Product 2",
                            Rate = 10m
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Product 3",
                            Rate = 122m
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Product 4",
                            Rate = 202m
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Product 5",
                            Rate = 62m
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Product 6",
                            Rate = 12m
                        });
                });

            modelBuilder.Entity("ITIL_Lab_Test.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address 1",
                            Mobile = "017783447753",
                            Name = "Supplier 1"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address 2",
                            Mobile = "017783447751",
                            Name = "Supplier 2"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address 3",
                            Mobile = "017783447754",
                            Name = "Supplier 3"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Address 4",
                            Mobile = "017783447755",
                            Name = "Supplier 4"
                        });
                });

            modelBuilder.Entity("ITIL_Lab_Test.Models.Order", b =>
                {
                    b.HasOne("ITIL_Lab_Test.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITIL_Lab_Test.Models.OrderDetails", b =>
                {
                    b.HasOne("ITIL_Lab_Test.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITIL_Lab_Test.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
