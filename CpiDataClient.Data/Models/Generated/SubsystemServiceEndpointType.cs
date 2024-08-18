using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SubsystemServiceEndpointType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SubsystemServiceEndpoint> SubsystemServiceEndpoints { get; set; } = new List<SubsystemServiceEndpoint>();
}
