using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ErrorLogging
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

    public Guid ErrorLoggingId { get; set; }

    public string? DataTypeId { get; set; }

    public Guid? DataRecordId { get; set; }

    public DateTime? NgayUpdate { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? PositionGps { get; set; }

    public string? ComputerIp { get; set; }

    public string? ComputerName { get; set; }

    public string? ActionType { get; set; }

    public string? Description { get; set; }

    public string? SourceType { get; set; }
}
