﻿// <auto-generated />
using System;
using Carosa.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carosa.Core.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Carosa.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApartmentNo")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryIsoCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("HouseNo")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Carosa.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceAddressId")
                        .HasColumnType("int");

                    b.Property<bool>("InvoiceAddressSameAsHome")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HomeAddressId");

                    b.HasIndex("InvoiceAddressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Carosa.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceWhenNew")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ServiceAfterKm")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("UsagePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsagePriceType")
                        .HasColumnType("int");

                    b.Property<int>("VehicleBrandId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleBrandId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountryOfOriginIso")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("CurrentLatitude")
                        .HasColumnType("float");

                    b.Property<double>("CurrentLongitude")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("FirstUsageAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsBroken")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("NextServiceAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId")
                        .IsUnique();

                    b.ToTable("VehicleUnits");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleUnitReservation", b =>
            modelBuilder.Entity("Carosa.Entities.VehicleUnitUsage", b =>

                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("ReservationFulfilled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ReservedUntill")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("VehicleUnitId")

                    b.Property<int>("KilometersRun")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("UsageEndedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("VehicleUnitId")
                        .IsUnique();

                    b.ToTable("VehicleUnitReservations");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleUnitUsages");
                });

            modelBuilder.Entity("Carosa.Entities.Customer", b =>
                {
                    b.HasOne("Carosa.Entities.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId");

                    b.HasOne("Carosa.Entities.Address", "InvoiceAddress")
                        .WithMany()
                        .HasForeignKey("InvoiceAddressId");

                    b.Navigation("HomeAddress");

                    b.Navigation("InvoiceAddress");
                });

            modelBuilder.Entity("Carosa.Entities.Vehicle", b =>
                {
                    b.HasOne("Carosa.Entities.VehicleBrand", "VehicleBrand")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleBrand");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleUnit", b =>
                {
                    b.HasOne("Carosa.Entities.Vehicle", "Vehicle")
                        .WithOne("VehicleUnit")
                        .HasForeignKey("Carosa.Entities.VehicleUnit", "VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleUnitReservation", b =>
                {
                    b.HasOne("Carosa.Entities.Customer", "Customer")
                        .WithMany("VehicleUnitReservation")

            modelBuilder.Entity("Carosa.Entities.VehicleUnitUsage", b =>
                {
                    b.HasOne("Carosa.Entities.Customer", "Customer")
                        .WithMany("VehicleUnitUsage")
 
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carosa.Entities.VehicleUnit", "VehicleUnit")
                        .WithOne("VehicleUnitReservation")
                        .HasForeignKey("Carosa.Entities.VehicleUnitReservation", "VehicleUnitId")

                    b.HasOne("Carosa.Entities.Vehicle", "Vehicle")
                        .WithMany("VehicleUnitUsage")
                        .HasForeignKey("VehicleId")
 
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("VehicleUnit");

                    b.Navigation("Vehicle");
 
                });

            modelBuilder.Entity("Carosa.Entities.Customer", b =>
                {
                    b.Navigation("VehicleUnitReservation");

                    b.Navigation("VehicleUnitUsage");
                });

            modelBuilder.Entity("Carosa.Entities.Vehicle", b =>
                {
                    b.Navigation("VehicleUnit")
                        .IsRequired();

                    b.Navigation("VehicleUnitUsage");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleBrand", b =>
                {
                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Carosa.Entities.VehicleUnit", b =>
                {
                    b.Navigation("VehicleUnitReservation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
