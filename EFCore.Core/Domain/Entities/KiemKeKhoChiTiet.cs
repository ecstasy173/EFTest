using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class KiemKeKhoChiTiet
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

    public Guid KiemKeKhoChiTietId { get; set; }

    public int? NamPs { get; set; }

    public Guid? KiemKeKhoId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? KhoKiemKeId { get; set; }

    public Guid? TaiKhoanKhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public int? SanPhamWebId { get; set; }

    public Guid? SanPhamDonViTinhId { get; set; }

    public decimal? SoLuong { get; set; }

    public decimal? SoLuongHachToan { get; set; }

    public string? BarCodeRaw { get; set; }

    public decimal? KhoiLuong { get; set; }

    public decimal? DonGiaKiemKe { get; set; }

    public decimal? GiaTriKiemKe { get; set; }

    public string? GhiChu { get; set; }

    public int? SubLineNo { get; set; }

    public Guid? MauSacId { get; set; }

    public Guid? KichCoId { get; set; }

    public Guid? LoSanPhamId { get; set; }

    public Guid? NhomSanPhamId { get; set; }
}
