using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ChucVu
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

    public Guid ChucVuId { get; set; }

    public string? MaSo { get; set; }

    public string? TenChucVu { get; set; }

    public Guid? ParentId { get; set; }

    public bool? IsLeaf { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public bool? KhongSuDung { get; set; }
}
