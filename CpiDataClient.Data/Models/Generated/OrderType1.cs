using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderType1
{
    public int RecordNumber { get; set; }

    public int Id { get; set; }

    public string? Name { get; set; }

    public string? DisplayName { get; set; }

    public string? Description { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsActive { get; set; }

    public int? DefaultPriority { get; set; }

    public string? Regex { get; set; }

    public bool? CanManualCancel { get; set; }

    public bool IsDefault { get; set; }
}
