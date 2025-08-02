using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Permission
{
    public int Permissionid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? GroupId { get; set; }

    public string? GroupCode { get; set; }
}
