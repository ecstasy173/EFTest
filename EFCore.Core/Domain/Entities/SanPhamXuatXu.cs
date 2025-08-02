using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPhamXuatXu
{
    public Guid? SsClientId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid SanPhamXuatXuId { get; set; }

    public string? GhiChu { get; set; }

    public string? GiaTri { get; set; }
}
