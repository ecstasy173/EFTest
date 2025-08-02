using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DinhMucKhoChiTiet
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

    public Guid DinhMucKhoChiTietId { get; set; }

    public Guid? DinhMucKhoId { get; set; }

    public int? NamPs { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? TaiKhoanKhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public Guid? SanPhamDonViTinhId { get; set; }

    public decimal? SoLuongToiThieu { get; set; }

    public decimal? SoLuongToiDa { get; set; }

    public decimal? BienCanhBaoSoLuongToiThieu { get; set; }

    public decimal? BienCanhBaoSoLuongToiDa { get; set; }

    public decimal? BienCanhBaoTyLeToiThieu { get; set; }

    public decimal? BienCanhBaoTyLeToiDa { get; set; }

    public decimal? DonGia { get; set; }

    public decimal? GiaTriToiThieu { get; set; }

    public decimal? GiaTriToiDa { get; set; }

    public string? GhiChu { get; set; }

    public int? SubLineNo { get; set; }
}
