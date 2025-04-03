using System;
using System.Collections.Generic;

namespace CaseManagmaentSystem.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int? CaseId { get; set; }

    public int? UserId { get; set; }

    public string? Message { get; set; }

    public DateTime? SentAt { get; set; }

    public virtual Case? Case { get; set; }

    public virtual User? User { get; set; }
}
