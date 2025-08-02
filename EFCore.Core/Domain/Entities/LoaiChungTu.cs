using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class LoaiChungTu
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

    public Guid LoaiChungTuId { get; set; }

    public string? MaSo { get; set; }

    public string? TenLoaiChungTu { get; set; }

    public string? TenReport { get; set; }

    public bool? IsBuildin { get; set; }

    public bool? HasShortCut { get; set; }

    public bool? IsVisible { get; set; }

    public string? KyHieu { get; set; }

    public string? CommandCode { get; set; }

    public Guid? FormId { get; set; }

    public Guid? NhomLoaiChungTuId { get; set; }

    public Guid? TinhChatChungTuId { get; set; }

    public bool? InChungTuSauThemMoi { get; set; }

    public bool? DanhSoTuDong { get; set; }

    public int? DoDaiSoTuDong { get; set; }

    public string? PreFixAutoCode { get; set; }

    public string? PostFixAutoCode { get; set; }

    public bool? CanhBaoTonKho { get; set; }

    public bool? KiemSoatTonKho { get; set; }

    public bool? CanhBaoTonQuy { get; set; }

    public bool? KiemSoatTonQuy { get; set; }

    public bool? TuDongKhoaChungTu { get; set; }

    public int? SoNgayTuDongKhoa { get; set; }

    public Guid? TaiKhoanIdno { get; set; }

    public Guid? TaiKhoanIdco { get; set; }

    public Guid? KhoIdno { get; set; }

    public Guid? KhoIdco { get; set; }

    public Guid? PhanXuongIdno { get; set; }

    public Guid? PhanXuongIdco { get; set; }

    public bool? AllUser { get; set; }

    public bool? KhongSuDung { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public string? TenShortCut { get; set; }

    public string? FldName { get; set; }

    public string? TenBuildin { get; set; }
}
