using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class LoSanPhamKtk
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

    public Guid LoSanPhamId { get; set; }

    public string? MaSo { get; set; }

    public Guid? PhanXuongId { get; set; }

    public Guid? SanPhamId { get; set; }

    public string? MaHopNhat { get; set; }

    public DateTime? NgaySanXuat { get; set; }

    public DateTime? HanSuDung { get; set; }

    public string? GhiChu { get; set; }

    public int? LineNo { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? DonViId { get; set; }

    public string? TenLoSanPham { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public Guid? BizChungTuId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? DonViTinhId { get; set; }

    public decimal? DonGia { get; set; }

    public decimal? SoLuongDk { get; set; }

    public decimal? GiaTriDk { get; set; }

    public DateTime? NgayNhapTon { get; set; }

    public decimal? SoLuongNhap { get; set; }

    public decimal? GiaTriNhap { get; set; }

    public decimal? SoLuongXuat { get; set; }

    public decimal? GiaTriXuat { get; set; }

    public decimal? SoLuongTon { get; set; }

    public decimal? GiaTriTon { get; set; }

    public int? FlagCompleteGiaVon { get; set; }

    public Guid? NhomSanPhamId { get; set; }

    public string? MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? QuyCachGoi { get; set; }

    public Guid? LoaiSanPhamId { get; set; }
}
