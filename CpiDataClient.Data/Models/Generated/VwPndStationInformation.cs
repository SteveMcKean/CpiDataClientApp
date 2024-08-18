using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwPndStationInformation
{
    public string? Name { get; set; }

    public int? DirectionId { get; set; }

    public int? GroupId { get; set; }

    public int? Number { get; set; }

    public string? CellName { get; set; }

    public Guid EndpointId { get; set; }

    public int? Type { get; set; }

    public Guid? AisleId { get; set; }
}
