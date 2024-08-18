using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConveyorLane
{
    public int Id { get; set; }

    public string? EndpointId { get; set; }

    public string? ConveyorSubsystemRef { get; set; }

    public bool SynchronizeState { get; set; }

    public bool SynchronizeAvailability { get; set; }
}
