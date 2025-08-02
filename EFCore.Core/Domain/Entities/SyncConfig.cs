using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class SyncConfig
{
    public long Id { get; set; }

    public string? Donviid { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public DateTime? Syncdate { get; set; }

    public int? Status { get; set; }

    public int? Type { get; set; }
}
