using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Staff
{
    public Guid Id { get; set; }

    public int? ComId { get; set; }

    public Guid? RootId { get; set; }

    public Guid? DeptId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? AccountName { get; set; }

    public string? Policy { get; set; }

    public bool? IsLocked { get; set; }

    public bool? NhanVt { get; set; }
}
