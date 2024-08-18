using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Endpoint
{
    public int Id { get; set; }

    public string? SubsystemId { get; set; }

    public string? EndpointId { get; set; }

    public string? DisplayName { get; set; }

    public string? CustomerEndpointRef { get; set; }

    public int? EndPointType { get; set; }

    public bool RequiresWmsnotification { get; set; }
}
