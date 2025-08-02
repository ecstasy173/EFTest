using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class KiemKeKho
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

    public Guid KiemKeKhoId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public int? NamPs { get; set; }

    public string? SoHieu { get; set; }

    public string? InputId { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public DateTime? ThoiDiemPhatSinh { get; set; }

    public Guid? LyDoChungTuId { get; set; }

    public string? NoiDungKiemKe { get; set; }

    public Guid? NhanVienKiemKeId { get; set; }

    public string? ThongTinNhanVienKiemKe { get; set; }

    public Guid? ThuKhoId { get; set; }

    public string? ThongTinThuKho { get; set; }

    public Guid? NhanVienKeToanId { get; set; }

    public string? ThongTinNhanVienKeToan { get; set; }

    public Guid? NhanVienGiamSatId { get; set; }

    public string? ThongTinNhanVienGiamSat { get; set; }

    public Guid? KhoKiemKeId { get; set; }

    public Guid? TaiKhoanKhoId { get; set; }

    public int? LineNo { get; set; }

    public string? GhiChu { get; set; }

    public int? FlagApprove { get; set; }

    public int? FlagProcess { get; set; }

    public Guid? XuLyKiemKeId { get; set; }

    public Guid? TrangThaiId { get; set; }

    public int? FlagStatus { get; set; }

    public bool? SoHieuTuDong { get; set; }

    public string? ChuTichHoiDong { get; set; }

    public string? ChucVuChuTichHoiDong { get; set; }

    public string? UyVien1 { get; set; }

    public string? ChucVuUyVien1 { get; set; }

    public string? UyVien2 { get; set; }

    public string? ChucVuUyVien2 { get; set; }

    public string? UyVien3 { get; set; }

    public string? ChucVuUyVien3 { get; set; }

    public string? UyVien4 { get; set; }

    public string? ChucVuUyVien4 { get; set; }

    public string? UyVien5 { get; set; }

    public string? ChucVuUyVien5 { get; set; }

    public string? UyVien6 { get; set; }

    public string? ChucVuUyVien6 { get; set; }

    public string? UyVien7 { get; set; }

    public string? ChucVuUyVien7 { get; set; }

    public string? UyVien8 { get; set; }

    public string? ChucVuUyVien8 { get; set; }

    public string? UyVien9 { get; set; }

    public string? ChucVuUyVien9 { get; set; }

    public string? UyVien10 { get; set; }

    public string? ChucVuUyVien10 { get; set; }
}
