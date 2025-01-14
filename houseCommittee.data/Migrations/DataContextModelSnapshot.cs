﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using houseCommittee.data;

#nullable disable

namespace houseCommittee.data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("houseCommittee.core.models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MonthlyPayment")
                        .HasColumnType("int");

                    b.Property<string>("NameCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumBuilding")
                        .HasColumnType("int");

                    b.Property<int>("NumTenants")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BuildingList");
                });

            modelBuilder.Entity("houseCommittee.core.models.HouseCommittee", b =>
                {
                    b.Property<string>("PhoneHouseCommittee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FamilyHouseCommittee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstHouseCommittee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailHouseCommittee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneHouseCommittee");

                    b.ToTable("HouseCommitteeList");
                });

            modelBuilder.Entity("houseCommittee.core.models.Message", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeMessage")
                        .HasColumnType("datetime2");

                    b.Property<string>("target")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Title");

                    b.ToTable("MessageList");
                });

            modelBuilder.Entity("houseCommittee.core.models.Tenant", b =>
                {
                    b.Property<string>("PhoneTenant")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AmounPayments")
                        .HasColumnType("int");

                    b.Property<int>("ApartmentNumber")
                        .HasColumnType("int");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("CodeTenant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailTenant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneTenant");

                    b.HasIndex("BuildingId");

                    b.ToTable("TenantList");
                });

            modelBuilder.Entity("houseCommittee.core.models.Tenant", b =>
                {
                    b.HasOne("houseCommittee.core.models.Building", null)
                        .WithMany("Tenant")
                        .HasForeignKey("BuildingId");
                });

            modelBuilder.Entity("houseCommittee.core.models.Building", b =>
                {
                    b.Navigation("Tenant");
                });
#pragma warning restore 612, 618
        }
    }
}
