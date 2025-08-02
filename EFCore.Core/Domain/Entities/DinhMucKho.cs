using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DinhMucKho
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

    public Guid DinhMucKhoId { get; set; }

    public int? NamPs { get; set; }

    public string? SoHieu { get; set; }

    public bool? SoHieuTuDong { get; set; }

    public string? InputId { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public DateTime? NgayHieuLucBatDau { get; set; }

    public DateTime? NgayHieuLucKetThuc { get; set; }

    public int? LineNo { get; set; }

    public string? GhiChu { get; set; }

    public int? FlagApprove { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? TaiKhoanKhoId { get; set; }
}
