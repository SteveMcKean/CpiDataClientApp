using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Driveway
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public int LevelMapModelId { get; set; }

    public string? Name { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? OriginPointX { get; set; }

    public int? OriginPointY { get; set; }
}
