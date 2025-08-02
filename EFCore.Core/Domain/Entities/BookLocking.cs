using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class BookLocking
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

    public Guid BookLockingId { get; set; }

    public Guid? DonViId { get; set; }

    public Guid? KhoId { get; set; }

    public Guid? NguoiKhoaSoId { get; set; }

    public int? LockingYear { get; set; }

    public int? LockingMonth { get; set; }

    public DateTime? LockingStartDay { get; set; }

    public DateTime? LockingEndDay { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? NgayThucHien { get; set; }

    public bool? CoHieuLuc { get; set; }
}
