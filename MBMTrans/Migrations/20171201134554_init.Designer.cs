﻿// <auto-generated />
using MBMTrans.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MBMTrans.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20171201134554_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("MBMTrans.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<int?>("RoleId");

                    b.Property<string>("Surname");

                    b.Property<string>("Token");

                    b.Property<string>("Verificated");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MBMTrans.Models.Auto.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("MBMTrans.Models.Auto.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<int?>("CarId");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CarId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("MBMTrans.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<string>("Sity");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("MBMTrans.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<string>("EndAddress");

                    b.Property<string>("StartAddress");

                    b.Property<decimal>("Symmary");

                    b.Property<int?>("TariffId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("TariffId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MBMTrans.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MBMTrans.Models.Tariff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.HasKey("Id");

                    b.ToTable("Tariff");
                });

            modelBuilder.Entity("MBMTrans.Models.Account", b =>
                {
                    b.HasOne("MBMTrans.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("MBMTrans.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("MBMTrans.Models.Auto.Driver", b =>
                {
                    b.HasOne("MBMTrans.Models.Account", "Account")
                        .WithMany("Drivers")
                        .HasForeignKey("AccountId");

                    b.HasOne("MBMTrans.Models.Auto.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("MBMTrans.Models.Order", b =>
                {
                    b.HasOne("MBMTrans.Models.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountId");

                    b.HasOne("MBMTrans.Models.Tariff", "Tariff")
                        .WithMany()
                        .HasForeignKey("TariffId");
                });
#pragma warning restore 612, 618
        }
    }
}
