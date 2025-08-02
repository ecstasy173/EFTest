using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ChungTuNum
{
    public long Id { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public string? LoaiChungTu { get; set; }

    public Guid? KhoId { get; set; }

    public int? Year { get; set; }

    public int? Quater { get; set; }

    public decimal? StartNum { get; set; }

    public decimal? CurrentNum { get; set; }

    public DateTime? StartDate { get; set; }

    public bool? IsLocked { get; set; }

    public int? NumLen { get; set; }

    public string? Format { get; set; }
}
