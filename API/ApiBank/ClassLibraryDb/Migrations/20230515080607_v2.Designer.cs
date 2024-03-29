﻿// <auto-generated />
using System;
using ClassLibraryDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibraryDb.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20230515080607_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassLibraryModels.BankTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Transaction Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Transaction_Amount")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)")
                        .HasColumnName("transaction_amount");

                    b.Property<DateTime?>("Transaction_Date")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("transaction_date");

                    b.Property<long>("Transaction_From")
                        .HasColumnType("bigint")
                        .HasColumnName("transaction_from");

                    b.Property<long>("Transaction_To")
                        .HasColumnType("bigint")
                        .HasColumnName("transaction_to");

                    b.HasKey("Id");

                    b.ToTable("BankTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
