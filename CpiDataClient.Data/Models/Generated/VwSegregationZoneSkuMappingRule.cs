using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationZoneSkuMappingRule
{
    public int SegregationZoneId { get; set; }

    public string PropertyName { get; set; } = null!;

    public string ProductTypeName { get; set; } = null!;

    public int? ProductTypeValue { get; set; }

    public int? AllergenTypeValue { get; set; }
}
