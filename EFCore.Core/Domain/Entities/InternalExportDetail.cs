using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class InternalExportDetail
{
    public long Id { get; set; }

    public long? InternalExportId { get; set; }

    public Guid? DonViId { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? KhoGiaoDichId { get; set; }

    public Guid? PhanXuongId { get; set; }

    public Guid? DoiTuongCpid { get; set; }

    public string? LyDoXuat { get; set; }

    public Guid? SanPhamId { get; set; }

    public string? MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? XuatXu { get; set; }

    public string? DonViTinh { get; set; }

    public decimal? SoLuong { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? CreateBy { get; set; }

    public int? Status { get; set; }

    public long? DoiTuongId { get; set; }
}
