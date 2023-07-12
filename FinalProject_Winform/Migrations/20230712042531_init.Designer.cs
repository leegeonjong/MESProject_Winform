﻿// <auto-generated />
using System;
using FinalProject_Winform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject_Winform.Migrations
{
    [DbContext(typeof(FinalDbContext))]
    [Migration("20230712042531_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Check", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Check_item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Check_value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProcessId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.ToTable("Check");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Item_amount")
                        .HasColumnType("bigint");

                    b.Property<string>("Item_barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Item_baseLine")
                        .HasColumnType("bigint");

                    b.Property<string>("Item_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Lot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long>("Lot_amount")
                        .HasColumnType("bigint");

                    b.Property<string>("Lot_barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lot_break")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Lot_regDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lot_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Lot");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.LotHistory", b =>
                {
                    b.Property<long>("LotHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LotHistoryId"));

                    b.Property<DateTime?>("LotHistory_endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LotHistory_startDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LotId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProcessId")
                        .HasColumnType("bigint");

                    b.HasKey("LotHistoryId");

                    b.HasIndex("LotId");

                    b.HasIndex("ProcessId");

                    b.ToTable("LotHistory");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Order_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Order_count")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Order_endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Order_sendDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Order_startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Process", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool?>("Process_checkRight")
                        .HasColumnType("bit");

                    b.Property<string>("Process_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Process_status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Process");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Stock", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long>("Stock_amount")
                        .HasColumnType("bigint");

                    b.Property<long>("Stock_regAmount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Stock_regDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Stock_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("PUser_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PUser_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PUser_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PUser_phoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PUser");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Check", b =>
                {
                    b.HasOne("FinalProject_Winform.Models.domain.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Lot", b =>
                {
                    b.HasOne("FinalProject_Winform.Models.domain.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.LotHistory", b =>
                {
                    b.HasOne("FinalProject_Winform.Models.domain.Lot", "Lot")
                        .WithMany()
                        .HasForeignKey("LotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject_Winform.Models.domain.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lot");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Order", b =>
                {
                    b.HasOne("FinalProject_Winform.Models.domain.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("FinalProject_Winform.Models.domain.Stock", b =>
                {
                    b.HasOne("FinalProject_Winform.Models.domain.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
