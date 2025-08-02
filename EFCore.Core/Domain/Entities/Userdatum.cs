using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Userdatum
{
    public Guid Userid { get; set; }

    public string? FullName { get; set; }

    public string Username { get; set; } = null!;

    public int? Type { get; set; }

    public string Password { get; set; } = null!;

    public int? PasswordFormat { get; set; }

    public string? PasswordSalt { get; set; }

    public string? Email { get; set; }

    public string? PasswordQuestion { get; set; }

    public string? PasswordAnswer { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime CreateDate { get; set; }

    public int? FailedPassAttemptCount { get; set; }

    public string? GroupName { get; set; }

    public string? Policy { get; set; }

    public bool? IsManager { get; set; }
}
