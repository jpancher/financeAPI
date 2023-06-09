﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using financeAPI.Data;

#nullable disable

namespace financeAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230510123108_uniqueNames")]
    partial class uniqueNames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("financeAPI.Models.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountNumber")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Agency")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("BankName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("BankNumber")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Observation")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("\"Name\" IS NOT NULL");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("financeAPI.Models.ChartOfAccounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<bool>("ShowIncomeStatement")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("\"Name\" IS NOT NULL");

                    b.ToTable("ChartOfAccounts");
                });

            modelBuilder.Entity("financeAPI.Models.CostCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("\"Name\" IS NOT NULL");

                    b.ToTable("CostCenter");
                });

            modelBuilder.Entity("financeAPI.Models.Supplier", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("County")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Document")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Guid");

                    b.HasIndex("Document")
                        .IsUnique()
                        .HasFilter("\"Document\" IS NOT NULL");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("\"Name\" IS NOT NULL");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("financeAPI.Models.Transaction", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<DateTime>("AccrualDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("BankAccountId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("ChartOfAccountsId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("CostCenterEntityId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<decimal>("PenaltyAndInterestOrDiscount")
                        .HasPrecision(18, 4)
                        .HasColumnType("DECIMAL(18,4)");

                    b.Property<string>("Status")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<Guid?>("SupplierGuid")
                        .HasColumnType("RAW(16)");

                    b.Property<int?>("TransactionTypeId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("Value")
                        .HasPrecision(18, 4)
                        .HasColumnType("DECIMAL(18,4)");

                    b.HasKey("Guid");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("ChartOfAccountsId");

                    b.HasIndex("CostCenterEntityId");

                    b.HasIndex("SupplierGuid");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("financeAPI.Models.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("financeAPI.Models.Transaction", b =>
                {
                    b.HasOne("financeAPI.Models.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountId");

                    b.HasOne("financeAPI.Models.ChartOfAccounts", "ChartOfAccounts")
                        .WithMany()
                        .HasForeignKey("ChartOfAccountsId");

                    b.HasOne("financeAPI.Models.CostCenter", "CostCenterEntity")
                        .WithMany()
                        .HasForeignKey("CostCenterEntityId");

                    b.HasOne("financeAPI.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierGuid");

                    b.HasOne("financeAPI.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId");

                    b.Navigation("BankAccount");

                    b.Navigation("ChartOfAccounts");

                    b.Navigation("CostCenterEntity");

                    b.Navigation("Supplier");

                    b.Navigation("TransactionType");
                });
#pragma warning restore 612, 618
        }
    }
}
