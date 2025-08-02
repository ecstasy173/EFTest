using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class TransactionDatum
{
    public long Id { get; set; }

    public Guid? SsClientId { get; set; }

    public Guid? LoSanPhamId { get; set; }

    public Guid? BizChungTuId { get; set; }

    public Guid? TaiKhoanId { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public Guid? SanPhamId { get; set; }

    public Guid? KhoId { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public decimal? SoLuong { get; set; }

    public decimal? TongTien { get; set; }

    public decimal? DonGia { get; set; }

    public int? Type { get; set; }

    public int? Status { get; set; }

    public DateTime? NgayThucHien { get; set; }

    public decimal? SoLuongNhap { get; set; }

    public decimal? GiaTriNhap { get; set; }

    public decimal? SoLuongXuat { get; set; }

    public decimal? GiaTriXuat { get; set; }
}
