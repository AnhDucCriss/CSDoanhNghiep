﻿// <auto-generated />
using System;
using DuAn2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DuAn2.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20240614024523_Initdb9")]
    partial class Initdb9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DuAn2.Data.GiaoVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdTrinhDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cccd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maGiaoVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maThue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nganHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int?>("soDienThoai")
                        .HasColumnType("int");

                    b.Property<int?>("soTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("tenGiaoVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("giaoViens");
                });

            modelBuilder.Entity("DuAn2.Data.HocVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ghiChuCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ghiChuMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maHocVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("soDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soDTCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soDTMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenHocVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hocViens");
                });

            modelBuilder.Entity("DuAn2.Data.LichDay", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GiaoVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("gioBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("gioKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int?>("thu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("lichDays");
                });

            modelBuilder.Entity("DuAn2.Data.MucTienCong", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GiaoVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MonHocId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TaiNha30p")
                        .HasColumnType("float");

                    b.Property<double?>("TaiNha45p")
                        .HasColumnType("float");

                    b.Property<double?>("TaiNha60p")
                        .HasColumnType("float");

                    b.Property<double?>("TaiTrungTam30p")
                        .HasColumnType("float");

                    b.Property<double?>("TaiTrungTam45p")
                        .HasColumnType("float");

                    b.Property<double?>("TaiTrungTam60p")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("mucTienCongs");
                });

            modelBuilder.Entity("DuAn2.Data.TimeSlot", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Confirm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NgayTrongTuan")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeNow")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("timeSlots");
                });
#pragma warning restore 612, 618
        }
    }
}
