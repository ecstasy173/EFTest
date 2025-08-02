using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NhatKyChung
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

    public Guid NhatKyChungId { get; set; }

    public int? NamTc { get; set; }

    public Guid? KyBaoCaoId { get; set; }

    public string? DataId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public Guid? ChungTuId { get; set; }

    public Guid? ChungTuChiTietId { get; set; }

    public string? SoChungTu { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public DateTime? NgayHachToan { get; set; }

    public Guid? TaiKhoanIdno { get; set; }

    public Guid? TaiKhoanIdco { get; set; }

    public decimal? GiaTriTien { get; set; }

    public Guid? HopDongId { get; set; }

    public Guid? HoaDonId { get; set; }

    public string? NoiDung { get; set; }

    public string? GhiChu { get; set; }

    public int? LineNo { get; set; }

    public bool? IsAuto { get; set; }

    public int? FlagProcess { get; set; }

    public string? DataName { get; set; }

    public Guid? NghiepVuId { get; set; }

    public string? DataNameParent { get; set; }

    public string? AsemblyName { get; set; }

    public string? DienGiaiChungTu { get; set; }

    public DateTime? NgayPhanBoBatDauNo { get; set; }

    public DateTime? NgayPhanBoKetThucNo { get; set; }

    public DateTime? NgayPhanBoBatDauCo { get; set; }

    public DateTime? NgayPhanBoKetThucCo { get; set; }

    public Guid? KhoanMucIdno { get; set; }

    public Guid? KhoanMucIdco { get; set; }

    public Guid? VuViecIdno { get; set; }

    public Guid? VuViecIdco { get; set; }

    public string? SoHoaDon { get; set; }

    public string? KyHieuHoaDon { get; set; }

    public DateTime? NgayHoaDon { get; set; }

    public Guid? VuViecId { get; set; }

    public long? IdchungTu { get; set; }
}
