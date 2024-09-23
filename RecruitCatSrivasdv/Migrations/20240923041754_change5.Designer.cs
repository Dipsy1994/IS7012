﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatSrivasdv.Data;

#nullable disable

namespace RecruitCatSrivasdv.Migrations
{
    [DbContext(typeof(RecruitCatSrivasdvContext))]
    [Migration("20240923041754_change5")]
    partial class change5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Candidate", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("contactNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("optStartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("reference")
                        .HasColumnType("bit");

                    b.Property<string>("referenceID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool?>("relocation")
                        .HasColumnType("bit");

                    b.Property<decimal?>("targetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Company", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<string>("ISIN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("keyPeople")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("maximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("minimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("noOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal?>("revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("IndustryId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Industry", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("NumberOfCompanies")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.JobTitle", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<string>("jobDescription")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("maximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("minimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("optionalStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("typeOfEmployee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Candidate", b =>
                {
                    b.HasOne("RecruitCatSrivasdv.Models.Company", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyId");

                    b.HasOne("RecruitCatSrivasdv.Models.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatSrivasdv.Models.JobTitle", "JobTitle")
                        .WithMany("Candidates")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Industry");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Company", b =>
                {
                    b.HasOne("RecruitCatSrivasdv.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Company", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.Industry", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Companies");
                });

            modelBuilder.Entity("RecruitCatSrivasdv.Models.JobTitle", b =>
                {
                    b.Navigation("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
