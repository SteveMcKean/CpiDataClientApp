using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Subsystem1
{
    public Guid Id { get; set; }

    public string SubsystemId { get; set; } = null!;

    public string SubsystemType { get; set; } = null!;

    public int DesiredServiceStatus { get; set; }

    public int DesiredOperationalStatus { get; set; }

    public string? Version { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual SubsystemOperationalStatus DesiredOperationalStatusNavigation { get; set; } = null!;

    public virtual SubsystemServiceStatus DesiredServiceStatusNavigation { get; set; } = null!;

    public virtual ICollection<Endpoint1> Endpoint1s { get; set; } = new List<Endpoint1>();

    public virtual ICollection<SubsystemServiceEndpoint> SubsystemServiceEndpoints { get; set; } = new List<SubsystemServiceEndpoint>();
}
