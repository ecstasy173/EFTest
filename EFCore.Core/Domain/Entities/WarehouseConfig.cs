using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class WarehouseConfig
{
    public int Id { get; set; }

    public int? ComId { get; set; }

    public Guid? DonViId { get; set; }

    public string? KhoSanPhamDomain { get; set; }

    public string? KhoSanPhamService { get; set; }

    public string? LoSanPhamDomain { get; set; }

    public string? LoSanPhamService { get; set; }

    public string? TongHopLoSanPhamDomain { get; set; }

    public string? TongHopLoSanPhamService { get; set; }
}
