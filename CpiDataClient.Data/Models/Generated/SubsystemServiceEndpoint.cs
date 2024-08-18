using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SubsystemServiceEndpoint
{
    public Guid Id { get; set; }

    public Guid SubsystemId { get; set; }

    public string Name { get; set; } = null!;

    public string Contract { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int EndpointType { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual SubsystemServiceEndpointType EndpointTypeNavigation { get; set; } = null!;

    public virtual Subsystem1 Subsystem { get; set; } = null!;
}
