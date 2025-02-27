﻿// <auto-generated />
using System;
using DemoEFCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoEFCodeFirst.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20250119085152_Baitest01")]
    partial class Baitest01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoEFCodeFirst.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("ProductId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.BillDetail", b =>
                {
                    b.Property<int>("BillDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillDetailId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProductName1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillDetailId");

                    b.HasIndex("BillId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.Bill", b =>
                {
                    b.HasOne("DemoEFCodeFirst.Models.Product", null)
                        .WithMany("bill")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.BillDetail", b =>
                {
                    b.HasOne("DemoEFCodeFirst.Models.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.ProductDetail", b =>
                {
                    b.HasOne("DemoEFCodeFirst.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("DemoEFCodeFirst.Models.Product", b =>
                {
                    b.Navigation("bill");
                });
#pragma warning restore 612, 618
        }
    }
}
