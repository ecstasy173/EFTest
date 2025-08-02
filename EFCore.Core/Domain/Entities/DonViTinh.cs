using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DonViTinh
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

    public Guid DonViTinhId { get; set; }

    public string? MaSo { get; set; }

    public string? TenDonViTinh { get; set; }

    public string? KyHieu { get; set; }

    public Guid? NhomDonViTinhId { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public decimal? TyLeQuyDoi { get; set; }
}
