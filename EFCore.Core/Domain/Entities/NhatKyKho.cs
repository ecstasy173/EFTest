using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NhatKyKho
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

    public long Id { get; set; }

    public int? NamTc { get; set; }

    public Guid? KyBaoCaoId { get; set; }

    public Guid? NhatKyChungId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public Guid? ChungTuId { get; set; }

    public Guid? ChungTuChiTietId { get; set; }

    public string? SoChungTu { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public DateTime? NgayHachToan { get; set; }

    public Guid? TaiKhoanIdno { get; set; }

    public Guid? TaiKhoanIdco { get; set; }

    public Guid? KhoIdno { get; set; }

    public Guid? SanPhamIdno { get; set; }

    public decimal? SoLuongNo { get; set; }

    public decimal? DonGiaNo { get; set; }

    public Guid? KhoIdco { get; set; }

    public Guid? SanPhamIdco { get; set; }

    public decimal? SoLuongCo { get; set; }

    public decimal? DonGiaCo { get; set; }

    public decimal? GiaTriTien { get; set; }

    public string? NoiDung { get; set; }

    public string? GhiChu { get; set; }

    public int? LineNo { get; set; }

    public bool? IsAuto { get; set; }

    public int? FlagProcess { get; set; }

    public bool? IsGiaVonTuDong { get; set; }

    public Guid? GiaVonXuatKhoId { get; set; }

    public int? FlagTinhGiaVon { get; set; }

    public int? FlagCompleteGiaVon { get; set; }

    public Guid? MauSacIdno { get; set; }

    public Guid? KichCoIdno { get; set; }

    public Guid? MauSacIdco { get; set; }

    public Guid? KichCoIdco { get; set; }

    public Guid? VuViecId { get; set; }

    public Guid? LoSanPhamIdno { get; set; }

    public Guid? LoSanPhamIdco { get; set; }

    public string? MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? QuyCachGoi { get; set; }

    public long? IdchungTu { get; set; }

    public long? IdchungTuChiTiet { get; set; }
}
