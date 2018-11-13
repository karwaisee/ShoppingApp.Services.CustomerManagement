﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ShoppingApp.Services.CustomerManagement.DAL;
using ShoppingApp.Services.CustomerManagement.Models;
using System;

namespace ShoppingApp.Services.CustomerManagement.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoppingApp.Services.CustomerManagement.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("Contact");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<decimal>("CreditLimit");

                    b.Property<decimal>("CreditOwe");

                    b.Property<string>("Email");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("Postcode");

                    b.Property<string>("State");

                    b.Property<int>("Status");

                    b.Property<string>("Suburb");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}