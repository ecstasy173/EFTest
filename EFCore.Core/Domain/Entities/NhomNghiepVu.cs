using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NhomNghiepVu
{
    public int Id { get; set; }

    public string? MaSo { get; set; }

    public string? Ten { get; set; }

    public int? ComId { get; set; }
}
