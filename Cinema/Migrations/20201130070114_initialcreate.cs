using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoan = table.Column<string>(maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 300, nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_CumRap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCum = table.Column<string>(maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_CumRap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_LoaiPhim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_LoaiPhim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_ThanhVien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 100, nullable: false),
                    HinhAnh = table.Column<string>(maxLength: 50, nullable: true),
                    GioiTinh = table.Column<string>(maxLength: 3, nullable: false),
                    SDT = table.Column<string>(maxLength: 14, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    TaiKhoan = table.Column<string>(maxLength: 300, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 300, nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ThanhVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_RapPhim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRap = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: false),
                    HinhAnh = table.Column<string>(nullable: false),
                    MaCumRap = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_RapPhim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_RapPhim_tb_CumRap_MaCumRap",
                        column: x => x.MaCumRap,
                        principalTable: "tb_CumRap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Phim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(maxLength: 50, nullable: false),
                    ThoiLuong = table.Column<int>(nullable: false),
                    DaoDien = table.Column<string>(maxLength: 50, nullable: true),
                    DienVien = table.Column<string>(maxLength: 50, nullable: true),
                    QuocGia = table.Column<string>(maxLength: 50, nullable: true),
                    Mota = table.Column<string>(maxLength: 1000, nullable: true),
                    HinhAnh = table.Column<string>(nullable: false),
                    Trailer = table.Column<string>(nullable: true),
                    NgayPhatHanh = table.Column<DateTime>(nullable: false),
                    MaLoai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Phim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Phim_tb_LoaiPhim_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "tb_LoaiPhim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_HoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
                    MaThanhVien = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_HoaDon_tb_ThanhVien_MaThanhVien",
                        column: x => x.MaThanhVien,
                        principalTable: "tb_ThanhVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Phong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<int>(maxLength: 50, nullable: false),
                    MaRap = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Phong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Phong_tb_RapPhim_MaRap",
                        column: x => x.MaRap,
                        principalTable: "tb_RapPhim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_HangGhe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHang = table.Column<string>(maxLength: 1, nullable: false),
                    MaPhong = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_HangGhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_HangGhe_tb_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "tb_Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_SuatChieu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayChieu = table.Column<DateTime>(nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    MaPhong = table.Column<int>(nullable: false),
                    MaPhim = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_SuatChieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_SuatChieu_tb_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "tb_Phim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_SuatChieu_tb_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "tb_Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Ghe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGhe = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    MaHangGhe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Ghe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Ghe_tb_HangGhe_MaHangGhe",
                        column: x => x.MaHangGhe,
                        principalTable: "tb_HangGhe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Ve",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gia = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
                    MaHoaDon = table.Column<int>(nullable: false),
                    MaGhe = table.Column<int>(nullable: false),
                    MaSuat = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Ve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Ve_tb_Ghe_MaGhe",
                        column: x => x.MaGhe,
                        principalTable: "tb_Ghe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Ve_tb_HoaDon_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "tb_HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Ve_tb_SuatChieu_MaSuat",
                        column: x => x.MaSuat,
                        principalTable: "tb_SuatChieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ghe_MaHangGhe",
                table: "tb_Ghe",
                column: "MaHangGhe");

            migrationBuilder.CreateIndex(
                name: "IX_tb_HangGhe_MaPhong",
                table: "tb_HangGhe",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_tb_HoaDon_MaThanhVien",
                table: "tb_HoaDon",
                column: "MaThanhVien");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Phim_MaLoai",
                table: "tb_Phim",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Phong_MaRap",
                table: "tb_Phong",
                column: "MaRap");

            migrationBuilder.CreateIndex(
                name: "IX_tb_RapPhim_MaCumRap",
                table: "tb_RapPhim",
                column: "MaCumRap");

            migrationBuilder.CreateIndex(
                name: "IX_tb_SuatChieu_MaPhim",
                table: "tb_SuatChieu",
                column: "MaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_tb_SuatChieu_MaPhong",
                table: "tb_SuatChieu",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ve_MaGhe",
                table: "tb_Ve",
                column: "MaGhe");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ve_MaHoaDon",
                table: "tb_Ve",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ve_MaSuat",
                table: "tb_Ve",
                column: "MaSuat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Admin");

            migrationBuilder.DropTable(
                name: "tb_Ve");

            migrationBuilder.DropTable(
                name: "tb_Ghe");

            migrationBuilder.DropTable(
                name: "tb_HoaDon");

            migrationBuilder.DropTable(
                name: "tb_SuatChieu");

            migrationBuilder.DropTable(
                name: "tb_HangGhe");

            migrationBuilder.DropTable(
                name: "tb_ThanhVien");

            migrationBuilder.DropTable(
                name: "tb_Phim");

            migrationBuilder.DropTable(
                name: "tb_Phong");

            migrationBuilder.DropTable(
                name: "tb_LoaiPhim");

            migrationBuilder.DropTable(
                name: "tb_RapPhim");

            migrationBuilder.DropTable(
                name: "tb_CumRap");
        }
    }
}
