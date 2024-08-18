using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Aisle
{
    public int Id { get; set; }

    public int Number { get; set; }

    public int LevelMapModelId { get; set; }

    public string? Name { get; set; }

    public int? Type { get; set; }

    public int? ZoneType { get; set; }

    public int? Orientation { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? EndPointX { get; set; }

    public int? EndPointY { get; set; }

    public int? StartPointX { get; set; }

    public int? StartPointY { get; set; }

    public int? OriginX { get; set; }

    public int? OriginY { get; set; }
}
