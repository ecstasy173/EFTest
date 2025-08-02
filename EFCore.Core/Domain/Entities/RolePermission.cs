using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class RolePermission
{
    public int Permissionid { get; set; }

    public int Roleid { get; set; }
}
