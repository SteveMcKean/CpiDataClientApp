using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwEndpointConnectionInformation
{
    public int Id { get; set; }

    public Guid? InEndpointId { get; set; }

    public string? InEndpointName { get; set; }

    public Guid? OutEndpointId { get; set; }

    public string? OutEndpointName { get; set; }
}
