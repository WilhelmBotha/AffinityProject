﻿// <auto-generated />
using System;
using DataContext.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataContext.Migrations
{
    [DbContext(typeof(AffinityContext))]
    [Migration("20200506073329_Initial-Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataContext.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DataContext.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DataContext.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(15, 3)");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique()
                        .HasName("IX_OrderDetail");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("DataContext.Models.Order", b =>
                {
                    b.HasOne("DataContext.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Order_CustomerId");
                });

            modelBuilder.Entity("DataContext.Models.OrderDetail", b =>
                {
                    b.HasOne("DataContext.Models.Order", "Order")
                        .WithOne("OrderDetail")
                        .HasForeignKey("DataContext.Models.OrderDetail", "OrderId")
                        .HasConstraintName("FK_OrderDetail_Order");
                });
#pragma warning restore 612, 618
        }
    }
}
