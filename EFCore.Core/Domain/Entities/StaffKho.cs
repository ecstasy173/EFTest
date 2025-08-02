using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class StaffKho
{
    public Guid? KhoId { get; set; }

    public Guid? StaffId { get; set; }
}
