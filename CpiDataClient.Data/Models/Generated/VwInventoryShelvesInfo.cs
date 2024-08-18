using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInventoryShelvesInfo
{
    public Guid Id { get; set; }

    public int Level { get; set; }

    public int Aisle { get; set; }

    public string? Side { get; set; }

    public int Bay { get; set; }

    public int Shelf { get; set; }

    public int GlobalX { get; set; }

    public int GlobalY { get; set; }

    public int Length { get; set; }

    public int Depth { get; set; }

    public int HeightType { get; set; }

    public int MaxStorageWeight { get; set; }

    public int? SegregationZoneId { get; set; }
}
