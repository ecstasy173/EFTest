using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NoiDungPhieu
{
    public Guid Id { get; set; }

    public Guid? LoaiChungTu { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? DonViId { get; set; }
}
