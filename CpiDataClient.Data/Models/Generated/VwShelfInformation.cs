using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwShelfInformation
{
    public int LevelNumber { get; set; }

    public int AisleNumber { get; set; }

    public int BayNumber { get; set; }

    public int ShelfNumber { get; set; }

    public int ShelfSide { get; set; }

    public string? ShelfName { get; set; }

    public string? ResourceName { get; set; }

    public string? Name { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public int? OffsetX { get; set; }

    public int? OffsetY { get; set; }

    public int? OffsetZ { get; set; }

    public int? MaxStorageWeight { get; set; }

    public int? MaxStorageHeight { get; set; }

    public Guid LevelId { get; set; }

    public Guid AisleId { get; set; }

    public Guid BayId { get; set; }
}
