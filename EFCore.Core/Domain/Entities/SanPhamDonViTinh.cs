using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPhamDonViTinh
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

    public Guid SanPhamDonViTinhId { get; set; }

    public Guid? SanPhamId { get; set; }

    public string? DonViTinhQuyDoi { get; set; }

    public decimal? TyLeQuyDoi { get; set; }

    public string? QuyCachDongGoi { get; set; }

    public string? KyHieuDonViTinh { get; set; }

    public decimal? DonGiaBaoBi { get; set; }

    public bool? MacDinh { get; set; }

    public bool? DonViCoBan { get; set; }

    public bool? KhongSuDung { get; set; }

    public int? SubLineNo { get; set; }

    public string? Sku { get; set; }

    public bool? QuanLyBaoBi { get; set; }

    public bool? KiemKeThung { get; set; }
}
