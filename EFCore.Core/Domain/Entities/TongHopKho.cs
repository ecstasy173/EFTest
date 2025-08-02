using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class TongHopKho
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

    public Guid TongHopKhoId { get; set; }

    public int? NamTc { get; set; }

    public Guid? KyBaoCaoId { get; set; }

    public Guid? MaTongHop { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public DateTime? Ngay { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public decimal? SoLuongNhap { get; set; }

    public decimal? GiaTriNhap { get; set; }

    public decimal? SoLuongXuat { get; set; }

    public decimal? GiaTriXuat { get; set; }

    public decimal? LuyKeSoLuongNhap { get; set; }

    public decimal? LuyKeGiaTriNhap { get; set; }

    public decimal? LuyKeSoLuongXuat { get; set; }

    public decimal? LuyKeGiaTriXuat { get; set; }

    public decimal? DieuChinhSoLuongNhap { get; set; }

    public decimal? DieuChinhTienNhap { get; set; }

    public decimal? DieuChinhSoLuongXuat { get; set; }

    public decimal? DieuChinhTienXuat { get; set; }

    public decimal? DieuChinhLuyKeSoLuongNhap { get; set; }

    public decimal? DieuChinhLuyKeTienNhap { get; set; }

    public decimal? DieuChinhLuyKeSoLuongXuat { get; set; }

    public decimal? DieuChinhLuyKeTienXuat { get; set; }

    public int? FlagProcess { get; set; }

    public Guid? MauSacId { get; set; }

    public Guid? KichCoId { get; set; }
}
