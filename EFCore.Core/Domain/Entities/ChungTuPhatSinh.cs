using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ChungTuPhatSinh
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

    public Guid ChungTuPhatSinhId { get; set; }

    public int? NamTc { get; set; }

    public string? DataId { get; set; }

    public string? InputId { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public string? SoChungTu { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public DateTime? NgayHachToan { get; set; }

    public string? NoiDungPhatSinh { get; set; }

    public Guid? NguoiGiaoDichId { get; set; }

    public string? TenNguoiGiaoDich { get; set; }

    public string? DienThoaiNguoiGiaoDich { get; set; }

    public string? DiaChiNguoiGiaoDich { get; set; }

    public string? KemTheoChungTu { get; set; }

    public Guid? TienTeId { get; set; }

    public decimal? GiaTriTienNguyenTe { get; set; }

    public decimal? TienChuaThue { get; set; }

    public decimal? TienThue { get; set; }

    public decimal? TienCoThue { get; set; }

    public string? GhiChu { get; set; }

    public string? GiaTriTienBangChu { get; set; }

    public Guid? HoaDonId { get; set; }

    public Guid? HinhThucThanhToanId { get; set; }

    public Guid? TrangThaiId { get; set; }

    public string? MoTa { get; set; }

    public int? LineNo { get; set; }
}
