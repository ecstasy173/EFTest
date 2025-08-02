using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ChungTuNumWait
{
    public int Id { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public int? Year { get; set; }

    public int? Quater { get; set; }

    public decimal? SttChungTu { get; set; }

    public string? SoChungTu { get; set; }

    public DateOnly? NgayChungTu { get; set; }
}
