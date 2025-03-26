﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiShop.Cargo.DataAccessLayer.Concrete;

#nullable disable

namespace MultiShop.Cargo.DataAccessLayer.Migrations
{
    [DbContext(typeof(CargoContext))]
    [Migration("20250122110149_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MultiShop.Cargo.EntitiyLayer.Concrete.CargoCompany", b =>
                {
                    b.Property<int>("CargoCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoCompanyId"), 1L, 1);

                    b.Property<string>("CargoCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoCompanyId");

                    b.ToTable("CargoCompanies");
                });

            modelBuilder.Entity("MultiShop.Cargo.EntitiyLayer.Concrete.CargoCustomer", b =>
                {
                    b.Property<int>("CargoCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoCustomerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disctrict")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoCustomerId");

                    b.ToTable("CargoCustomers");
                });

            modelBuilder.Entity("MultiShop.Cargo.EntitiyLayer.Concrete.CargoDetail", b =>
                {
                    b.Property<int>("CargoDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoDetailId"), 1L, 1);

                    b.Property<int>("Barcode")
                        .HasColumnType("int");

                    b.Property<int>("CargoCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoDetailId");

                    b.HasIndex("CargoCompanyId");

                    b.ToTable("CargoDetails");
                });

            modelBuilder.Entity("MultiShop.Cargo.EntitiyLayer.Concrete.CargoOperation", b =>
                {
                    b.Property<int>("CargoOperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoOperationId"), 1L, 1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CargoOperationId");

                    b.ToTable("CargoOperations");
                });

            modelBuilder.Entity("MultiShop.Cargo.EntitiyLayer.Concrete.CargoDetail", b =>
                {
                    b.HasOne("MultiShop.Cargo.EntitiyLayer.Concrete.CargoCompany", "CargoCompany")
                        .WithMany()
                        .HasForeignKey("CargoCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoCompany");
                });
#pragma warning restore 612, 618
        }
    }
}
