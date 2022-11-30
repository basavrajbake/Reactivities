﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221130182645_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Venue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Domain.CustomerDetail", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardAssigned")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CutID")
                        .HasColumnType("TEXT");

                    b.Property<string>("IDProof")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("Domain.HotelServices", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Roomtype")
                        .HasColumnType("TEXT");

                    b.Property<string>("Services")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubService")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("HotelServices");
                });

            modelBuilder.Entity("Domain.RoomBookingStatus", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomID")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomStatus")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("RoomBookingStatuses");
                });

            modelBuilder.Entity("Domain.TotalRooms", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomID")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomType")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TotalRooms");
                });

            modelBuilder.Entity("Domain.TransactionTableforUserAction", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustCardIssued")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustRoomNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustRoomType")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustServicePrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustServiceUsed")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TransactionTableforUserAction");
                });
#pragma warning restore 612, 618
        }
    }
}
