using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class HopDongDoiTac
{
    public Guid HopDongId { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? DoiTacId { get; set; }

    public string? SoHopDong { get; set; }

    public DateTime? NgayHopDong { get; set; }

    public string? MoTa { get; set; }
}
