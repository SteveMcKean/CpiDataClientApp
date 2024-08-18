using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwDestination
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int DestinationId { get; set; }

    public string? EndpointId { get; set; }
}
