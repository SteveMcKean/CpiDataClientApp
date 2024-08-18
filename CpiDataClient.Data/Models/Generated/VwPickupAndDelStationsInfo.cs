using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwPickupAndDelStationsInfo
{
    public Guid? Id { get; set; }

    public Guid PndId { get; set; }

    public string? PndName { get; set; }

    public string? ConvBufName { get; set; }

    public int VerticalId { get; set; }

    public int OrderId { get; set; }

    public int DestinationId { get; set; }

    public int Type { get; set; }

    public Guid? AisleId { get; set; }

    public int? Aisle { get; set; }

    public Guid? LevelId { get; set; }

    public int? Level { get; set; }
}
