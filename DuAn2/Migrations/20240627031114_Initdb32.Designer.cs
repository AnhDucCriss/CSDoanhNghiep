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
    [Migration("20240627031114_Initdb32")]
    partial class Initdb32
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

                    b.Property<string>("IdLopHoc")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("DuAn2.Data.KhungGio", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("value")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("khungGios");
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

            modelBuilder.Entity("DuAn2.Data.LichHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("GioBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GioKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<double>("HocPhi")
                        .HasColumnType("float");

                    b.Property<string>("IdLopHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<int>("Thu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("lichHocs");
                });

            modelBuilder.Entity("DuAn2.Data.LichTKB", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Confirm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<int>("Thu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("lichTKBs");
                });

            modelBuilder.Entity("DuAn2.Data.LopHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdGiaoVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPhongHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TietHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("lopHocs");
                });

            modelBuilder.Entity("DuAn2.Data.LopHocVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("HocVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdLop")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("HocVienId");

                    b.ToTable("lopHocViens");
                });

            modelBuilder.Entity("DuAn2.Data.MonHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("monHocs");
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

                    b.Property<string>("KhungGioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NgayTrongTuan")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KhungGioId");

                    b.ToTable("timeSlots");
                });

            modelBuilder.Entity("DuAn2.Data.TKB", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("GioBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GioKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayHoc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Thu")
                        .HasColumnType("int");

                    b.Property<string>("TietHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TKBs");
                });

            modelBuilder.Entity("DuAn2.Data.LopHocVien", b =>
                {
                    b.HasOne("DuAn2.Data.HocVien", "HocVien")
                        .WithMany()
                        .HasForeignKey("HocVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocVien");
                });

            modelBuilder.Entity("DuAn2.Data.TimeSlot", b =>
                {
                    b.HasOne("DuAn2.Data.KhungGio", null)
                        .WithMany("TimeSlots")
                        .HasForeignKey("KhungGioId");
                });

            modelBuilder.Entity("DuAn2.Data.KhungGio", b =>
                {
                    b.Navigation("TimeSlots");
                });
#pragma warning restore 612, 618
        }
    }
}
