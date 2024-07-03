﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyDuAn.Data;

#nullable disable

namespace QuanLyDuAn.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20240607072951_Initdb12")]
    partial class Initdb12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuanLyDuAn.Data.DungCu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenDungCu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("dungCus");
                });

            modelBuilder.Entity("QuanLyDuAn.Data.GiaoVien", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrinhDoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cccd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maThue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nganHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("soDienThoai")
                        .HasColumnType("int");

                    b.Property<int>("soTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("tenGiaoVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("giaoViens");
                });

            modelBuilder.Entity("QuanLyDuAn.Data.MonHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("monHocs");
                });

            modelBuilder.Entity("QuanLyDuAn.Data.PhongHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenPhongHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("phongHocs");
                });

            modelBuilder.Entity("QuanLyDuAn.Data.PhongHoc_DungCu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DungCuId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhongHocId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("phongHoc_DungCus");
                });

            modelBuilder.Entity("QuanLyDuAn.Data.TrinhDo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTrinhDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("trinhDos");
                });
#pragma warning restore 612, 618
        }
    }
}
