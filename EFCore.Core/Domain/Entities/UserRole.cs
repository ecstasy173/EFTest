using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class UserRole
{
    public int Roleid { get; set; }

    public Guid? Userid { get; set; }
}
