using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConveyorLane1
{
    public Guid Id { get; set; }

    public string? ConveyorSubsystemRef { get; set; }

    public bool SynchronizeState { get; set; }

    public bool SynchronizeAvailability { get; set; }

    public virtual Endpoint1 IdNavigation { get; set; } = null!;

    public virtual ICollection<InboundCarton> InboundCartonInboundConveyors { get; set; } = new List<InboundCarton>();

    public virtual ICollection<InboundCarton> InboundCartonRejectConveyors { get; set; } = new List<InboundCarton>();

    public virtual ICollection<InboundConveyorLoad> InboundConveyorLoads { get; set; } = new List<InboundConveyorLoad>();
}
