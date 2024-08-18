using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBuildStructureCacheForBayViewer
{
    public Guid Id { get; set; }

    public Guid ShelfId { get; set; }

    public int ShelfNumber { get; set; }

    public string? ShelfName { get; set; }

    public int ShelfSide { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Modifieddate { get; set; }

    public string Modifiedby { get; set; } = null!;

    public Guid BayId { get; set; }

    public int BayNumber { get; set; }

    public string? BayName { get; set; }

    public int BaySide { get; set; }

    public Guid AisleId { get; set; }

    public int AisleNumber { get; set; }

    public string? AisleName { get; set; }

    public Guid ZoneId { get; set; }

    public int ZoneNumber { get; set; }

    public string? ZoneName { get; set; }

    public Guid LevelId { get; set; }

    public int LevelNumber { get; set; }

    public string? LevelName { get; set; }
}
