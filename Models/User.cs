using System;
using System.Collections.Generic;

namespace CaseManagmaentSystem.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Role { get; set; }

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
