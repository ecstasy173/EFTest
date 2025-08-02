using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class PhanXuong
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

    public Guid PhanXuongId { get; set; }

    public string? MaSo { get; set; }

    public string? TenPhanXuong { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public bool? KhongSuDung { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? ParentId { get; set; }

    public bool? IsLeaf { get; set; }

    public string? QuanDoc { get; set; }
}
