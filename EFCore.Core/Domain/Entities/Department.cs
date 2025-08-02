using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Department
{
    public Guid Id { get; set; }

    public int? ComId { get; set; }

    public Guid? RootId { get; set; }

    public Guid? ParentId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Policy { get; set; }

    public bool? IsCompany { get; set; }

    public string? Manager { get; set; }

    public int? Type { get; set; }

    public bool? DoiTuongChiPhiTheoKho { get; set; }

    public bool? KiemKeTheoDonGia { get; set; }

    public bool? DoiTuongChiPhiKhongTheoPx { get; set; }

    public bool? ChungTuNhieuDtcp { get; set; }

    public bool? DungFormatCu { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsInternalExport { get; set; }
}
