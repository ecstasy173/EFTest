using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ChietKhau
{
    public long ChietKhauId { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid? DraftId { get; set; }

    public string? SoChungTu { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? DoiTacId { get; set; }

    public string? TenNguoiGiaoDich { get; set; }

    public string? KemTheoChungTu { get; set; }

    public Guid? KhoGiaoDichId { get; set; }

    public decimal? TongTienChuaThue { get; set; }

    public decimal? TienThue { get; set; }

    public decimal? TongTienCoThue { get; set; }

    public string? GhiChu { get; set; }

    public string? KyTenNguoiLapPhieu { get; set; }

    public string? HoaDonMauSo { get; set; }

    public string? HoaDonSoHieu { get; set; }

    public string? HoaDonKyHieu { get; set; }

    public DateTime? HoaDonNgayPhatSinh { get; set; }

    public string? NoiDungPhatSinh { get; set; }

    public string? SoHopDong { get; set; }

    public DateTime? NgayHopDong { get; set; }

    public bool? IsDraft { get; set; }
}
