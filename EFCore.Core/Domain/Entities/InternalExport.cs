using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class InternalExport
{
    public long Id { get; set; }

    public Guid? DonViId { get; set; }

    public string? SoChungTu { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? KhoGiaoDichId { get; set; }

    public Guid? PhanXuongId { get; set; }

    public string? PhanXuong { get; set; }

    public Guid? DoiTuongCpid { get; set; }

    public string? DoiTuongCp { get; set; }

    public string? NguoiNhan { get; set; }

    public string? LyDoXuat { get; set; }

    public decimal? TongCong { get; set; }

    public string? TenThuKho { get; set; }

    public string? TenNguoiNhan { get; set; }

    public string? TenKtvatTu { get; set; }

    public string? TenQuanDoc { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? CreateBy { get; set; }

    public int? Status { get; set; }

    public long? DoiTuongId { get; set; }
}
