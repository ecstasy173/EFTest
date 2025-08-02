using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ReportRecord
{
    public long Id { get; set; }

    public int? ComId { get; set; }

    public Guid? SsClientId { get; set; }

    public int? Status { get; set; }

    public int? Type { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public int? TotalRecord { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? Reportby { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? ReportData { get; set; }

    public Guid? NhomSanPhamId { get; set; }

    public string? Name { get; set; }
}
