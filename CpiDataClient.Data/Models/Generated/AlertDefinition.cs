using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertDefinition
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int RelevanceTime { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string RecoveryOptions { get; set; } = null!;

    public int AlertTypeId { get; set; }

    public int AlertSeverityId { get; set; }

    public string HardwareOriginType { get; set; } = null!;

    public string ResolutionOwner { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public DateTimeOffset CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<AlertItem> AlertItems { get; set; } = new List<AlertItem>();

    public virtual AlertSeverity AlertSeverity { get; set; } = null!;

    public virtual AlertType AlertType { get; set; } = null!;
}
