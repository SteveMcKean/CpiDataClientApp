using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Alert1
{
    public int Id { get; set; }

    public int AlertCode { get; set; }

    public string Name { get; set; } = null!;

    public int AlertType { get; set; }

    public string HardwareOriginType { get; set; } = null!;

    public int Severity { get; set; }

    public string ResolutionOwner { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public int RelevanceTime { get; set; }

    public string Description { get; set; } = null!;

    public string RecoveryOptions { get; set; } = null!;
}
