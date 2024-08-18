using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwZoneInformation
{
    public string ZoneName { get; set; } = null!;

    public int LevelNumber { get; set; }

    public int SafetyZoneNumber { get; set; }

    public int? AisleNumber { get; set; }

    public Guid ZoneId { get; set; }

    public int SafetyZoneRef { get; set; }
}
