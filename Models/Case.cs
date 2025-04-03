using System;
using System.Collections.Generic;

namespace CaseManagmaentSystem.Models;

public partial class Case
{
    public int CaseId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Status { get; set; }

    public int? AssignedUserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual User? AssignedUser { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
