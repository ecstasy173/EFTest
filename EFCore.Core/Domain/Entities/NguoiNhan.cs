using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NguoiNhan
{
    public long Id { get; set; }

    public Guid? DonViId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? NgayPhatSinh { get; set; }

    public Guid? PhanXuongId { get; set; }
}
