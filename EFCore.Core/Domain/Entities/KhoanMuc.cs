using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class KhoanMuc
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

    public Guid KhoanMucId { get; set; }

    public string? MaSo { get; set; }

    public string? TenKhoanMuc { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public Guid? TaiKhoanChiPhiId { get; set; }

    public Guid? TinhChatKhoanMucId { get; set; }
}
