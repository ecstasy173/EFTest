using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SanPhamNum
{
    public int Id { get; set; }

    public Guid? DonViId { get; set; }

    public string? Code { get; set; }

    public decimal? CurrentNum { get; set; }

    public int? NumView { get; set; }

    public int? Type { get; set; }
}
