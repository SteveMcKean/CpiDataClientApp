using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Endpoint1
{
    public Guid Id { get; set; }

    public string? EndpointId { get; set; }

    public string? CustomerEndpointRef { get; set; }

    public string? DisplayName { get; set; }

    public Guid? SubsystemId { get; set; }

    public bool RequiresWmsnotification { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ConveyorLane1? ConveyorLane1 { get; set; }

    public virtual PickupAndDeliveryStation1? PickupAndDeliveryStation1 { get; set; }

    public virtual Scanner1? Scanner1 { get; set; }

    public virtual Subsystem1? Subsystem { get; set; }

    public virtual VerticalConveyorSide? VerticalConveyorSide { get; set; }

    public virtual ICollection<Destination> Destinations { get; set; } = new List<Destination>();
}
