﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThanTai.Models;

#nullable disable

namespace ThanTai.Migrations
{
    [DbContext(typeof(ThanTaiShopDbContext))]
    [Migration("20250228083802_CSD8")]
    partial class CSD8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ThanTai.Models.DatHang", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DiaChiGiaoHang")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DienThoaiGiaoHang")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("NgayDatHang")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiDungID")
                        .HasColumnType("int");

                    b.Property<string>("TenNguoiDat")
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<int>("TinhTrangID")
                        .HasColumnType("int");

                    b.Property<bool>("TinhTrangThanhToan")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("NguoiDungID");

                    b.HasIndex("TinhTrangID");

                    b.ToTable("DatHang");
                });

            modelBuilder.Entity("ThanTai.Models.DatHangChiTiet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DatHangID")
                        .HasColumnType("int");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamID")
                        .HasColumnType("int");

                    b.Property<short>("SoLuong")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("DatHangID");

                    b.HasIndex("SanPhamID");

                    b.ToTable("DatHangChiTiet");
                });

            modelBuilder.Entity("ThanTai.Models.GiaTriThuocTinh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("GiaTri")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("SanPhamID")
                        .HasColumnType("int");

                    b.Property<int>("ThuocTinhID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SanPhamID");

                    b.HasIndex("ThuocTinhID");

                    b.ToTable("GiaTriThuocTinh");
                });

            modelBuilder.Entity("ThanTai.Models.GioHang", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("NguoiDungID")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamID")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NguoiDungID");

                    b.HasIndex("SanPhamID");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("ThanTai.Models.HinhAnhSanPham", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AnhSanPham")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("AnhThongSo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("SanPhamID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SanPhamID");

                    b.ToTable("HinhAnhSanPham");
                });

            modelBuilder.Entity("ThanTai.Models.LoaiSanPham", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<string>("Tenloai")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("ThanTai.Models.NguoiDung", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("HoVaTen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Quyen")
                        .HasColumnType("bit");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("ThanTai.Models.SanPham", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LoaiSanPhamID")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("ntext");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ThuongHieuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LoaiSanPhamID");

                    b.HasIndex("ThuongHieuID");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("ThanTai.Models.ThuocTinh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TenThuocTinh")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("ThuocTinh");
                });

            modelBuilder.Entity("ThanTai.Models.ThuongHieu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TenThuongHieu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("ThanTai.Models.TinhTrang", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("TinhTrang");
                });

            modelBuilder.Entity("ThanTai.Models.DatHang", b =>
                {
                    b.HasOne("ThanTai.Models.NguoiDung", "NguoiDung")
                        .WithMany("DatHang")
                        .HasForeignKey("NguoiDungID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanTai.Models.TinhTrang", "TinhTrang")
                        .WithMany("DatHang")
                        .HasForeignKey("TinhTrangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("TinhTrang");
                });

            modelBuilder.Entity("ThanTai.Models.DatHangChiTiet", b =>
                {
                    b.HasOne("ThanTai.Models.DatHang", "DatHang")
                        .WithMany("DatHangChiTiet")
                        .HasForeignKey("DatHangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanTai.Models.SanPham", "SanPham")
                        .WithMany("DatHangChiTiet")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DatHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ThanTai.Models.GiaTriThuocTinh", b =>
                {
                    b.HasOne("ThanTai.Models.SanPham", "SanPham")
                        .WithMany("GiaTriThuocTinhs")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanTai.Models.ThuocTinh", "ThuocTinh")
                        .WithMany("GiaTriThuocTinhs")
                        .HasForeignKey("ThuocTinhID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");

                    b.Navigation("ThuocTinh");
                });

            modelBuilder.Entity("ThanTai.Models.GioHang", b =>
                {
                    b.HasOne("ThanTai.Models.NguoiDung", "NguoiDung")
                        .WithMany("GioHang")
                        .HasForeignKey("NguoiDungID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanTai.Models.SanPham", "SanPham")
                        .WithMany("GioHang")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ThanTai.Models.HinhAnhSanPham", b =>
                {
                    b.HasOne("ThanTai.Models.SanPham", "SanPham")
                        .WithMany("HinhAnhSanPham")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ThanTai.Models.LoaiSanPham", b =>
                {
                    b.HasOne("ThanTai.Models.LoaiSanPham", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentID");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("ThanTai.Models.SanPham", b =>
                {
                    b.HasOne("ThanTai.Models.LoaiSanPham", "LoaiSanPham")
                        .WithMany("SanPham")
                        .HasForeignKey("LoaiSanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanTai.Models.ThuongHieu", "ThuongHieu")
                        .WithMany("SanPham")
                        .HasForeignKey("ThuongHieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSanPham");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("ThanTai.Models.DatHang", b =>
                {
                    b.Navigation("DatHangChiTiet");
                });

            modelBuilder.Entity("ThanTai.Models.LoaiSanPham", b =>
                {
                    b.Navigation("SanPham");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("ThanTai.Models.NguoiDung", b =>
                {
                    b.Navigation("DatHang");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("ThanTai.Models.SanPham", b =>
                {
                    b.Navigation("DatHangChiTiet");

                    b.Navigation("GiaTriThuocTinhs");

                    b.Navigation("GioHang");

                    b.Navigation("HinhAnhSanPham");
                });

            modelBuilder.Entity("ThanTai.Models.ThuocTinh", b =>
                {
                    b.Navigation("GiaTriThuocTinhs");
                });

            modelBuilder.Entity("ThanTai.Models.ThuongHieu", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ThanTai.Models.TinhTrang", b =>
                {
                    b.Navigation("DatHang");
                });
#pragma warning restore 612, 618
        }
    }
}
