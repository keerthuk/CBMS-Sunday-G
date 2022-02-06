﻿// <auto-generated />
using System;
using CBMS.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CBMS.DAL.Migrations
{
    [DbContext(typeof(CityBusManagementDbContext))]
    [Migration("20220205125707_addedroutedetails")]
    partial class addedroutedetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CBMS.Entity.Model.BusDetails", b =>
                {
                    b.Property<int>("busNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("arrival")
                        .HasColumnType("time");

                    b.Property<string>("busName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("routeDetailsrouteNo")
                        .HasColumnType("int");

                    b.HasKey("busNo");

                    b.HasIndex("routeDetailsrouteNo");

                    b.ToTable("busdetails");
                });

            modelBuilder.Entity("CBMS.Entity.Model.RouteDetails", b =>
                {
                    b.Property<int>("routeNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("source")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("routeNo");

                    b.ToTable("routedetails");
                });

            modelBuilder.Entity("CBMS.Entity.Model.BusDetails", b =>
                {
                    b.HasOne("CBMS.Entity.Model.RouteDetails", "routeDetails")
                        .WithMany("busdetails")
                        .HasForeignKey("routeDetailsrouteNo");

                    b.Navigation("routeDetails");
                });

            modelBuilder.Entity("CBMS.Entity.Model.RouteDetails", b =>
                {
                    b.Navigation("busdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
