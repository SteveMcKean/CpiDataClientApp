using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationZoneIdsForInventory
{
    public int? SegregationZoneId { get; set; }

    public Guid? CartonId { get; set; }

    public int CaseGroupNumber { get; set; }
}
