using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DepartmentConfig
{
    public Guid Id { get; set; }

    public Guid? DeptId { get; set; }

    public Guid? KhoId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public bool? IsCommon { get; set; }

    public int? Type { get; set; }
}
