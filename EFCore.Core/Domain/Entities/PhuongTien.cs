using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class PhuongTien
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

    public Guid PhuongTienId { get; set; }

    public string? MaSo { get; set; }

    public string? TenPhuongTien { get; set; }

    public Guid? LoaiPhuongTien { get; set; }

    public decimal? TaiTrongNum { get; set; }

    public string? TaiTrongText { get; set; }

    public string? BienSo { get; set; }

    public string? NhanHieu { get; set; }

    public string? SoLoai { get; set; }

    public string? TenSanPham { get; set; }

    public string? LoaiHinhLapRap { get; set; }

    public string? SoKhung { get; set; }

    public string? NuocSanXuatKhung { get; set; }

    public string? SoDongCo { get; set; }

    public string? NuocSanXuatDongCo { get; set; }

    public string? GcnclkieuLoai { get; set; }

    public DateTime? NgayCapGcnclkieuLoai { get; set; }

    public decimal? KhoiLuongBanThan { get; set; }

    public decimal? KhoiLuongHangChuyenCho { get; set; }

    public decimal? KhoiLuongToanBo { get; set; }

    public decimal? TheTichLamViecDongCo { get; set; }

    public decimal? SoNguoiChoPhep { get; set; }

    public string? MoTa { get; set; }

    public int? LineNo { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }
}
