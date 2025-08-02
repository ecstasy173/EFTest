using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DinhMucNguyenVatLieu
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

    public Guid DinhMucNguyenVatLieuId { get; set; }

    public Guid? ThanhPhamId { get; set; }

    public Guid? ChiPhiId { get; set; }

    public Guid? NguyenVatLieuId { get; set; }

    public decimal? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public decimal? GiaTriTien { get; set; }

    public string? MoTa { get; set; }

    public int? SubLineNo { get; set; }

    public int? NamPs { get; set; }
}
