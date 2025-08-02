using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DinhMucTieuHaoChiTiet
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

    public Guid DinhMucTieuHaoChiTietId { get; set; }

    public Guid? DinhMucTieuHaoId { get; set; }

    public int? NamPs { get; set; }

    public int? ThangPs { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? PhanXuongId { get; set; }

    public Guid? DoiTuongThcpid { get; set; }

    public string? YeuToChiPhi { get; set; }

    public Guid? SanPhamId { get; set; }

    public string? DonViTinh { get; set; }

    public decimal? DinhMuc { get; set; }

    public decimal? KhoiLuongCongViec { get; set; }

    public decimal? NhuCau { get; set; }

    public decimal? DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public string? GhiChu { get; set; }

    public decimal? KhoiLuongTk { get; set; }

    public decimal? DonGiaTk { get; set; }

    public Guid? NhomSanPhamId { get; set; }

    public Guid? LoaiSanPhamId { get; set; }

    public int? LevelNo { get; set; }

    public Guid? YeuToChiPhiId { get; set; }

    public long? DoiTuongId { get; set; }
}
