﻿// <auto-generated />
using System;
using JazzOpsApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JazzOpsApp.Migrations
{
    [DbContext(typeof(JazzDbContext))]
    [Migration("20190105191959_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JazzOpsApp.Models.IotNet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("IoTNets");
                });

            modelBuilder.Entity("JazzOpsApp.Models.Measurements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Humidity");

                    b.Property<DateTime>("MeasurementDate");

                    b.Property<double>("Pm10");

                    b.Property<double>("Pm25");

                    b.Property<double>("Precipitation");

                    b.Property<double>("Pressure");

                    b.Property<int?>("StationId");

                    b.Property<double>("Temperature");

                    b.Property<int>("WindDeg");

                    b.Property<double>("WindSpeed");

                    b.HasKey("Id");

                    b.HasIndex("StationId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("JazzOpsApp.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<int>("StationId");

                    b.Property<int?>("iotNetId");

                    b.HasKey("Id");

                    b.HasIndex("iotNetId");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("JazzOpsApp.Models.Measurements", b =>
                {
                    b.HasOne("JazzOpsApp.Models.Station", "Station")
                        .WithMany()
                        .HasForeignKey("StationId");
                });

            modelBuilder.Entity("JazzOpsApp.Models.Station", b =>
                {
                    b.HasOne("JazzOpsApp.Models.IotNet", "iotNet")
                        .WithMany()
                        .HasForeignKey("iotNetId");
                });
#pragma warning restore 612, 618
        }
    }
}
