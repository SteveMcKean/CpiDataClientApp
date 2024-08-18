using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Alert
{
    public Guid Id { get; set; }

    public int AlertCode { get; set; }

    public int AlertType { get; set; }

    public string HardwareOriginType { get; set; } = null!;

    public int Severity { get; set; }

    public string ResolutionOwner { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public int RelevanceTime { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string RecoveryOptions { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<AlertLog> AlertLogs { get; set; } = new List<AlertLog>();

    public virtual AlertType AlertTypeNavigation { get; set; } = null!;

    public virtual AlertSeverity SeverityNavigation { get; set; } = null!;
}
