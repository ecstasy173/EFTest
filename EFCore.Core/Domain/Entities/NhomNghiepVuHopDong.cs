using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NhomNghiepVuHopDong
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

    public Guid NhomNghiepVuHopDongId { get; set; }

    public string? MaSo { get; set; }

    public string? TenNhomNghiepVuHopDong { get; set; }

    public string? GhiChu { get; set; }

    public int? LineNo { get; set; }

    public Guid? TaiKhoanNoId { get; set; }

    public Guid? TaiKhoanCoId { get; set; }

    public string? Ftable { get; set; }

    public string? FnameDoiTacNo { get; set; }

    public string? FnameDoiTacCo { get; set; }

    public string? FnameTaiKhoanNganHangNo { get; set; }

    public string? FnameTaiKhoanNganHangCo { get; set; }
}
