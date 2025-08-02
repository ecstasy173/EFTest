using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class TongHopLoSanPhamChiTiet
{
    public long Id { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? ChungTuId { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public int? NamTc { get; set; }

    public Guid? LoaiChungTuId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? SanPhamId { get; set; }

    public string? MaHopNhat { get; set; }

    public string? QuyCachGoi { get; set; }

    public decimal? DonGiaLo { get; set; }

    public DateTime? NgayDangKy { get; set; }

    public decimal? SoLuongNhap { get; set; }

    public decimal? GiaTriNhap { get; set; }

    public decimal? SoLuongXuat { get; set; }

    public decimal? GiaTriXuat { get; set; }

    public decimal? LuyKeSoLuongNhap { get; set; }

    public decimal? LuyKeGiaTriNhap { get; set; }

    public decimal? LuyKeSoLuongXuat { get; set; }

    public decimal? LuyKeGiaTriXuat { get; set; }

    public decimal? SoLuongChietKhau { get; set; }

    public decimal? GiaTriChietKhau { get; set; }

    public decimal? LuyKeSoLuongChietKhau { get; set; }

    public decimal? LuyKeGiaTriChietKhau { get; set; }

    public Guid? LoSanPhamId { get; set; }
}
