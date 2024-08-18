using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationProductPropertyMap
{
    public int SegProductPropertyId { get; set; }

    public string SegProductPropertyName { get; set; } = null!;

    public string ProductPropertyName { get; set; } = null!;

    public int? RefProductTypeId { get; set; }

    public int? AllergenTypeId { get; set; }
}
