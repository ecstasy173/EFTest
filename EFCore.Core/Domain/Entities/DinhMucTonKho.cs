using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DinhMucTonKho
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

    public Guid DinhMucTonKhoId { get; set; }

    public int? NamTc { get; set; }

    public Guid? KyBaoCaoId { get; set; }

    public DateTime? NgayThietLap { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public decimal? SoLuongToiThieu { get; set; }

    public decimal? SoLuongToiDa { get; set; }

    public decimal? DonGia { get; set; }

    public decimal? GiaTriToiThieu { get; set; }

    public decimal? GiaTriToiDa { get; set; }

    public string? GhiChu { get; set; }

    public int? FlagProcess { get; set; }

    public Guid? MauSacId { get; set; }

    public Guid? KichCoId { get; set; }
}
