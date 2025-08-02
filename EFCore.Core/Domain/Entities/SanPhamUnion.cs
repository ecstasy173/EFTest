using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPhamUnion
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

    public Guid SanPhamUnionId { get; set; }

    public string? MaSo { get; set; }

    public string? TenSanPhamUnion { get; set; }

    public string? QuyCachGoi { get; set; }

    public string? GioiThieuSanPham { get; set; }

    public string? ThongTinSuDung { get; set; }

    public Guid? LoaiSanPhamId { get; set; }

    public int? LineNo { get; set; }

    public string? GhiChu { get; set; }
}
