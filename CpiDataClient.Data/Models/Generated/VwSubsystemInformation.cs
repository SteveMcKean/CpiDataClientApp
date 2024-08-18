using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSubsystemInformation
{
    public Guid Id { get; set; }

    public string? SubsystemId { get; set; }

    public string? SubsystemType { get; set; }

    public int DesiredServiceStatus { get; set; }

    public int DesiredOperationalStatus { get; set; }

    public string? Version { get; set; }
}
