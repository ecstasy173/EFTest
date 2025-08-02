using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPhamDinhMuc
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

    public Guid SanPhamDinhMucId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public decimal? SoLuongMin { get; set; }

    public decimal? SoLuongMax { get; set; }

    public string? GhiChu { get; set; }

    public Guid? MauSacId { get; set; }

    public Guid? KichCoId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public decimal? GiaTriMin { get; set; }

    public decimal? GiaTriMax { get; set; }
}
