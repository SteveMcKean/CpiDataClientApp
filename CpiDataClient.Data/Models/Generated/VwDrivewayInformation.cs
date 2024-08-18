using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwDrivewayInformation
{
    public string DrivewayNumber { get; set; } = null!;

    public string? Name { get; set; }

    public int? OriginPointX { get; set; }

    public int? OriginPointY { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int LevelMapModelId { get; set; }

    public int? ModuleNumber { get; set; }

    public int LevelNumber { get; set; }

    public Guid LevelId { get; set; }

    public Guid ModuleId { get; set; }

    public string? ResourceName { get; set; }
}
