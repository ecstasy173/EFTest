using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class PhiGiaoHang
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

    public Guid PhiGiaoHangId { get; set; }

    public bool? DonViCoBan { get; set; }

    public decimal? GiaBan1 { get; set; }

    public decimal? GiaBan2 { get; set; }

    public decimal? GiaBan3 { get; set; }

    public decimal? DonGiaBaoBi { get; set; }

    public bool? KiemSoatGia { get; set; }

    public decimal? GiaMin { get; set; }

    public decimal? GiaMax { get; set; }

    public bool? XacNhanThanhLy { get; set; }

    public string? NoiDungThanhLy { get; set; }

    public decimal? GiaBanThanhLy { get; set; }

    public bool? XacNhanChietKhau { get; set; }

    public int? LoaiChietKhau { get; set; }

    public decimal? ChietKhauTyLe { get; set; }

    public decimal? ChietKhauBangTien { get; set; }

    public string? NoiDungChietKhau { get; set; }

    public string? GhiChu { get; set; }
}
