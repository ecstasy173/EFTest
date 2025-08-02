using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ChietKhauChiTiet
{
    public long ChietKhauChiTietId { get; set; }

    public long? ChietKhauId { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? KhoGiaoDichId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid? DraftId { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public Guid? SanPhamId { get; set; }

    public decimal? SoLuongTon { get; set; }

    public decimal? GiaTriTon { get; set; }

    public decimal? DonGiaLo { get; set; }

    public decimal? ThanhTienChuaThue { get; set; }

    public decimal? ThanhTienCoThue { get; set; }

    public string? NoiDungChiTiet { get; set; }
}
