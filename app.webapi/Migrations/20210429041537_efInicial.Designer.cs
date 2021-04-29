﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app.WebApi.Data;

namespace app.WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210429041537_efInicial")]
    partial class efInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("app.webapi.Model.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("app.webapi.Model.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Credit_Limit")
                        .HasColumnType("decimal(37, 2)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("State")
                        .HasColumnType("char(2)");

                    b.Property<string>("Street")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("app.webapi.Model.Natural_person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("char(14)");

                    b.Property<int?>("CustomersId");

                    b.Property<int>("Id_Customer");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.ToTable("Natural_person");
                });

            modelBuilder.Entity("app.webapi.Model.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("CategoriesId");

                    b.Property<int>("Id_categories");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(37, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("app.webapi.Model.Natural_person", b =>
                {
                    b.HasOne("app.webapi.Model.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersId");
                });

            modelBuilder.Entity("app.webapi.Model.Products", b =>
                {
                    b.HasOne("app.webapi.Model.Categories", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesId");
                });
#pragma warning restore 612, 618
        }
    }
}
