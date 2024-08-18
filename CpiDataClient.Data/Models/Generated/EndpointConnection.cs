using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EndpointConnection
{
    public int Id { get; set; }

    public string? FromEndpointId { get; set; }

    public string? ToEndpointId { get; set; }
}
