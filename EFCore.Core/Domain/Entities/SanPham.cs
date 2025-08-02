using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPham
{
    public bool? SsIsLocked { get; set; }

    public bool? SsIsDeleted { get; set; }

    public Guid? SsClientId { get; set; }

    public Guid? SsLocationId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid? DraftId { get; set; }

    public Guid SanPhamId { get; set; }

    public string? MaSo { get; set; }

    public string? MaHopNhat { get; set; }

    public string? TenSanPham { get; set; }

    public Guid? DonViTinhId { get; set; }

    public string? QuyCachGoi { get; set; }

    public string? QuyCachDongGoi { get; set; }

    public bool? CoMaXuLy { get; set; }

    public bool? NhieuDonViTinh { get; set; }

    public string? Qrcode { get; set; }

    public Guid? NhaCungCapId { get; set; }

    public Guid? NhomSanPhamId { get; set; }

    public Guid? LoaiSanPhamId { get; set; }

    public Guid? TinhChatSanPhamId { get; set; }

    public bool? QuyCachKhoiLuong { get; set; }

    public decimal? QuyCachKhoiLuongMin { get; set; }

    public decimal? QuyCachKhoiLuongMax { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? TaiKhoanDoanhThuId { get; set; }

    public Guid? TaiKhoanKhoId { get; set; }

    public Guid? TaiKhoanGiaVonId { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public bool? KhongSuDung { get; set; }

    public byte[]? AnhDaiDien { get; set; }

    public string? DinhLuongText { get; set; }

    public decimal? DinhLuongGiaTri { get; set; }

    public string? DinhLuongDonVi { get; set; }

    public Guid? NuocSanXuatId { get; set; }

    public Guid? ThuongHieuId { get; set; }

    public int? WebId { get; set; }

    public bool? SanPhamWeb { get; set; }

    public int? FlagSaleStatus { get; set; }

    public string? AnhDaiDienUrl { get; set; }

    public decimal? ThueSuatGtgt { get; set; }

    public decimal? ThueSuatNk { get; set; }

    public decimal? ThueSuatXk { get; set; }

    public decimal? ThueSuatTtdb { get; set; }

    public bool? HachToanTheoHeThong { get; set; }

    public Guid? KhoNhapLaiId { get; set; }

    public Guid? TaiKhoanChietKhauId { get; set; }

    public Guid? TaiKhoanNhapLaiId { get; set; }

    public Guid? TaiKhoanDoanhThuNoiBoId { get; set; }

    public bool? TinhGiaVonTheoHeThong { get; set; }

    public bool? TinhGiaVonTheoNhom { get; set; }

    public Guid? PptinhGiaVonId { get; set; }

    public Guid? NhomThuocTinhId { get; set; }

    public string? GioiThieuSanPham { get; set; }

    public string? ThongTinSuDung { get; set; }

    public string? ThongTinBaoHanh { get; set; }

    public string? GhiChu { get; set; }

    public string? TagList { get; set; }

    public Guid? KieuLoaiId { get; set; }

    public Guid? MauSacId { get; set; }

    public Guid? KichCoId { get; set; }

    public bool? KhongChiuThueGtgt { get; set; }

    public bool? ChiuThueNk { get; set; }

    public bool? ChiuThueXk { get; set; }

    public bool? ChiuThueTtdb { get; set; }

    public bool? QuanLyDangKiem { get; set; }

    public bool? QuanLyTheoLo { get; set; }

    public decimal? GiaNhap { get; set; }

    public Guid? DknhanHieuId { get; set; }

    public Guid? DksoLoaiId { get; set; }

    public Guid? DkmauId { get; set; }

    public bool? ChiuThueMoiTruong { get; set; }

    public decimal? ThueSuatMoiTruong { get; set; }

    public string? TenSanPhamDayDu { get; set; }

    public bool? TamThoi { get; set; }

    public Guid? SanPhamUnionId { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? YeuToChiPhiId { get; set; }
}
