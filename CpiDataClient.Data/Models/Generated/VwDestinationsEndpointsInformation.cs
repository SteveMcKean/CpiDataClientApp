using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwDestinationsEndpointsInformation
{
    public Guid EndpointId { get; set; }

    public Guid DestinationId { get; set; }

    public int DestinationName { get; set; }

    public string EndpointName { get; set; } = null!;
}
