﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asset_project.API.Data;

#nullable disable

namespace asset_project.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524013937_AssetTypeDetail")]
    partial class AssetTypeDetail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("asset_project.Shared.Entities.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("PurchaseValue")
                        .HasColumnType("float");

                    b.Property<string>("Responsible")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsefullLifetime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.AssetDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Assetdetails");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("AssetTypes");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.AssetTypeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int");

                    b.Property<int?>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("PropertyId");

                    b.ToTable("AssetTypeDetail");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.HasIndex("Name", "StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.IdentificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("IdentificationTypes");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.MaintenanceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ClousureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Justification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusTypeId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("Id");

                    b.HasIndex("StatusTypeId");

                    b.ToTable("MaintenanceRequests");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NotificationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Recipient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("NotificationTypeId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.NotificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("name");

                    b.ToTable("NotificationTypes");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("IdentificationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("IdentificationTypeId");

                    b.HasIndex("IdentificationNumber", "IdentificationTypeId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AssetId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExecutionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name", "CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.StatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("MaintenanceRequest")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("WorkOrder")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("StatusTypes");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.WorkOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssignmentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaintenanceRequestId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TechnicianAssigned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TechnicianId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("MaintenanceRequestId");

                    b.HasIndex("StatusTypeId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.WorkOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttendedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServiceDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkOrderId")
                        .HasColumnType("int");

                    b.Property<string>("notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("WorkOrderDetails");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Asset", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.AssetType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asset_project.Shared.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetType");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.AssetDetail", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.AssetTypeDetail", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asset_project.Shared.Entities.AssetType", null)
                        .WithMany("Details")
                        .HasForeignKey("AssetTypeId");

                    b.HasOne("asset_project.Shared.Entities.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.City", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.MaintenanceRequest", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asset_project.Shared.Entities.StatusType", "StatusType")
                        .WithMany()
                        .HasForeignKey("StatusTypeId");

                    b.Navigation("Asset");

                    b.Navigation("StatusType");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Notification", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.NotificationType", "NotificationType")
                        .WithMany()
                        .HasForeignKey("NotificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotificationType");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Person", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asset_project.Shared.Entities.IdentificationType", "IdentificationType")
                        .WithMany()
                        .HasForeignKey("IdentificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("IdentificationType");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Schedule", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.State", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.WorkOrder", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.MaintenanceRequest", "MaintenanceRequest")
                        .WithMany()
                        .HasForeignKey("MaintenanceRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asset_project.Shared.Entities.StatusType", "StatusType")
                        .WithMany()
                        .HasForeignKey("StatusTypeId");

                    b.Navigation("MaintenanceRequest");

                    b.Navigation("StatusType");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.WorkOrderDetail", b =>
                {
                    b.HasOne("asset_project.Shared.Entities.WorkOrder", "WorkOrder")
                        .WithMany()
                        .HasForeignKey("WorkOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.AssetType", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("asset_project.Shared.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
