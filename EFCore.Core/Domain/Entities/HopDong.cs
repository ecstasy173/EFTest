using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class HopDong
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

    public Guid HopDongId { get; set; }

    public string? SoHopDong { get; set; }

    public DateTime? NgayKy { get; set; }

    public Guid? NgayHetHan { get; set; }

    public int? LoaiHopDong { get; set; }

    public int? LoaiNghiepVu { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? GhiChu { get; set; }
}
