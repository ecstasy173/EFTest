using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Role
{
    public int Roleid { get; set; }

    public string Name { get; set; } = null!;

    public string? Title { get; set; }

    public string? GroupId { get; set; }

    public bool? IsSysAdmin { get; set; }
}
