using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Company
{
    public int Id { get; set; }

    public string? Fkey { get; set; }

    public int? ParentId { get; set; }

    public string? ParentName { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Phone { get; set; }

    public string? TaxCode { get; set; }

    public string? AccountName { get; set; }

    public string? Domain { get; set; }
}
