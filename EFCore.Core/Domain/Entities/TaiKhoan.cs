using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class TaiKhoan
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

    public Guid TaiKhoanId { get; set; }

    public string? MaSo { get; set; }

    public string? TenTaiKhoan { get; set; }

    public bool? IsChiTiet { get; set; }

    public Guid? TaiKhoanIdparent { get; set; }

    public int? CapTaiKhoan { get; set; }

    public Guid? LoaiTaiKhoanId { get; set; }

    public Guid? TinhChatTaiKhoanId { get; set; }

    public bool? IsNgoaiBang { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public bool? PhanBoTheoNgay { get; set; }

    public bool? ChiTietVuViec { get; set; }

    public bool? ChiTietKhoanMuc { get; set; }

    public bool? ChiTietCongTrinh { get; set; }
}
