using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NghiepVu
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

    public Guid NghiepVuId { get; set; }

    public Guid? DonViId { get; set; }

    public string? MaSo { get; set; }

    public string? TenNghiepVu { get; set; }

    public Guid? NhomNghiepVuId { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public Guid? TaiKhoanIdno { get; set; }

    public Guid? TaiKhoanIdco { get; set; }

    public bool? BuildIn { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? PhanXuongId { get; set; }

    public Guid? ChiPhiId { get; set; }

    public Guid? DoiTuongThcpid { get; set; }

    public Guid? KhoanMucId { get; set; }

    public bool? HachToan { get; set; }

    public int? Type { get; set; }

    public long? DoiTuongId { get; set; }

    public string? MaNhom { get; set; }

    public int? ComId { get; set; }
}
