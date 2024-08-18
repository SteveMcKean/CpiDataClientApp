using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationEndpoint
{
    public int Id { get; set; }

    public int DestinationId { get; set; }

    public string EndpointId { get; set; } = null!;
}
