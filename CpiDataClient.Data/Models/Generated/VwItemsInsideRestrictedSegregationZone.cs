using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwItemsInsideRestrictedSegregationZone
{
    public Guid? Id { get; set; }

    public string Violation { get; set; } = null!;

    public int SegProductPropertyId { get; set; }

    public string SegProductPropertyName { get; set; } = null!;

    public Guid CartonId { get; set; }

    public Guid SkuId { get; set; }

    public string? Name { get; set; }

    public string? SkuDescription { get; set; }

    public int ProductTypes { get; set; }

    public string ProductTypeName { get; set; } = null!;

    public string? AllergenTypeName { get; set; }

    public int CaseGroupNumber { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public string? CustomerCartonGroupRef { get; set; }

    public Guid? ShelfId { get; set; }

    public string? BayName { get; set; }

    public bool? IsSuspect { get; set; }

    public DateTimeOffset? EnteringWarehouseTime { get; set; }

    public string ZoneDescription { get; set; } = null!;

    public string? ShelfName { get; set; }

    public Guid LevelId { get; set; }
}
