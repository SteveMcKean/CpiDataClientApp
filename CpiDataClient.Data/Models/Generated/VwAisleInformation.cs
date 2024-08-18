using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwAisleInformation
{
    public int AisleNumber { get; set; }

    public string? Name { get; set; }

    public string? ResourceName { get; set; }

    public int? StartPointX { get; set; }

    public int? StartPointY { get; set; }

    public int? EndPointX { get; set; }

    public int? EndPointY { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int LevelMapModelId { get; set; }

    public int? ModuleNumber { get; set; }

    public int? AisleType { get; set; }

    public int SafetyZoneNumber { get; set; }

    public string ZoneName { get; set; } = null!;

    public int LevelNumber { get; set; }

    public Guid LevelId { get; set; }

    public Guid ZoneId { get; set; }

    public Guid ModuleId { get; set; }
}
