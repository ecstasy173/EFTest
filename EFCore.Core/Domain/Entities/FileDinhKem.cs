using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class FileDinhKem
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

    public Guid FileDinhKemId { get; set; }

    public string? TableName { get; set; }

    public string? ModelName { get; set; }

    public Guid? RecordId { get; set; }

    public string? FileName { get; set; }

    public string? FileExtention { get; set; }

    public string? FileType { get; set; }

    public string? FileOverview { get; set; }

    public byte[]? FileContent { get; set; }

    public string? FileLink { get; set; }

    public decimal? FileSize { get; set; }

    public int? LineNo { get; set; }
}
