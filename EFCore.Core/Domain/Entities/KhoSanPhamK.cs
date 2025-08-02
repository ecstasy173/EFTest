using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class KhoSanPhamK
{
    public bool? SsIsLocked { get; set; }

    public bool? SsIsDeleted { get; set; }

    public Guid? SsClientId { get; set; }

    public Guid? SsLocationId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid KhoSanPhamId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public string? MaHopNhat { get; set; }

    public string? MaSo { get; set; }

    public DateTime? NgayDangKy { get; set; }

    public decimal? SoLuongDk { get; set; }

    public decimal? GiaTriDk { get; set; }

    public decimal? SoLuongNhap { get; set; }

    public decimal? GiaTriNhap { get; set; }

    public decimal? SoLuongXuat { get; set; }

    public decimal? GiaTriXuat { get; set; }

    public decimal? SoLuongCk { get; set; }

    public decimal? GiaTriCk { get; set; }

    public decimal? DieuChinhSoLuongNhap { get; set; }

    public decimal? DieuChinhTienNhap { get; set; }

    public decimal? DieuChinhSoLuongXuat { get; set; }

    public decimal? DieuChinhTienXuat { get; set; }

    public string? MoTa { get; set; }

    public string? GhiChu { get; set; }

    public Guid? NhomSanPhamId { get; set; }

    public string? MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? QuyCachGoi { get; set; }

    public Guid? LoaiSanPhamId { get; set; }
}
