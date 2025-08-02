using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DataLogging
{
    public Guid? SsClientId { get; set; }

    public long Id { get; set; }

    public string? DataTypeId { get; set; }

    public Guid? DataRecordId { get; set; }

    public DateTime? NgayUpdate { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? PositionGps { get; set; }

    public string? ComputerIp { get; set; }

    public string? ComputerName { get; set; }

    public string? ActionType { get; set; }

    public string? DataLoggingDetail { get; set; }

    public string? SourceType { get; set; }

    public string? DataLoggingCode { get; set; }

    public string? DataLoggingHeader { get; set; }
}
