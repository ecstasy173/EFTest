using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DoiTuongThcp
{
    public Guid? DraftId { get; set; }

    public Guid? DoiTuongThcpid { get; set; }

    public string? MaSo { get; set; }

    public string? TenDoiTuongThcp { get; set; }

    public string? NguoiChuQuan { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public bool? SsIsLocked { get; set; }

    public bool? SsIsDeleted { get; set; }

    public Guid? SsClientId { get; set; }

    public Guid? SsLocationId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? PhanXuongId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? SanPhamId { get; set; }

    public Guid? ThanhPhamId { get; set; }

    public int? LevelNo { get; set; }

    public bool? KhongSuDung { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? ChiPhiId { get; set; }

    public Guid? VuViecId { get; set; }

    public bool? IsLeaf { get; set; }

    public Guid? KhoId { get; set; }

    public string? GroupId { get; set; }

    public long DoiTuongId { get; set; }

    public long? DoiTuongChaId { get; set; }
}
