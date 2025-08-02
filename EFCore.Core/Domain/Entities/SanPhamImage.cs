using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPhamImage
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

    public Guid SanPhamImageId { get; set; }

    public Guid? SanPhamId { get; set; }

    public byte[]? ImageActualSize { get; set; }

    public byte[]? ImageSmall { get; set; }

    public string? ImageUrl { get; set; }

    public string? MoTa { get; set; }

    public int? OrderNo { get; set; }

    public bool? IsDefault { get; set; }
}
