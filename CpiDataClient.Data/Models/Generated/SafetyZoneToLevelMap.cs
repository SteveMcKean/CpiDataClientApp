using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SafetyZoneToLevelMap
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SafetyZoneId { get; set; }

    public int LevelId { get; set; }
}
