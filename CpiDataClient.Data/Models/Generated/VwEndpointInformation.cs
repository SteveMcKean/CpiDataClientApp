using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwEndpointInformation
{
    public Guid? EndpointId { get; set; }

    public string? EndpointName { get; set; }

    public string? DisplayName { get; set; }

    public string? CustomerEndpointRef { get; set; }

    public Guid? SubSystemId { get; set; }
}
