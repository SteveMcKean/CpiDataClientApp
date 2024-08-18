using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Shelf
{
    public int Id { get; set; }

    public int Number { get; set; }

    public int AisleId { get; set; }

    public int BayId { get; set; }

    public int LevelMapModelId { get; set; }

    public int Side { get; set; }

    public int? MaxStorageWeight { get; set; }

    public int? MaxStorageHeight { get; set; }

    public int? ModelId { get; set; }

    public string? Name { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public int? OffsetX { get; set; }

    public int? OffsetY { get; set; }

    public int? OffsetZ { get; set; }
}
