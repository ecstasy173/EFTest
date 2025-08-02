using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Permissiongroup
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }
}
