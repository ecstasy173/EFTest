using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class LoaiSanPhamTempNum
{
    public long Id { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public decimal? CurrentNum { get; set; }
}
