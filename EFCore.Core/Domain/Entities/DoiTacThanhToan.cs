using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DoiTacThanhToan
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

    public Guid DoiTacThanhToanId { get; set; }

    public Guid? DoiTacId { get; set; }

    public decimal? DuNoMin { get; set; }

    public decimal? DuNoMax { get; set; }

    public decimal? DuCoMin { get; set; }

    public decimal? DuCoMax { get; set; }

    public string? GhiChu { get; set; }
}
