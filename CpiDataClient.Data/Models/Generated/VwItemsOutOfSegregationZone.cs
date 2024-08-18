using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwItemsOutOfSegregationZone
{
    public string Violation { get; set; } = null!;

    public int SegProductPropertyId { get; set; }

    public string SegProductPropertyName { get; set; } = null!;

    public Guid CartonId { get; set; }

    public Guid SkuId { get; set; }

    public string? Name { get; set; }

    public string? SkuDescription { get; set; }

    public int ProductTypes { get; set; }

    public int AllergenTypeId { get; set; }

    public int CaseGroupNumber { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public string? CustomerCartonGroupRef { get; set; }

    public Guid? ShelfId { get; set; }

    public bool? IsSuspect { get; set; }

    public DateTimeOffset? EnteringWarehouseTime { get; set; }

    public Guid LevelId { get; set; }

    public string? ShelfName { get; set; }

    public string? BayName { get; set; }

    public Guid BayId { get; set; }
}
