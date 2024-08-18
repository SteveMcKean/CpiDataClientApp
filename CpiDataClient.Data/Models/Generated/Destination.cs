using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Destination
{
    public Guid Id { get; set; }

    public string? CustomerRef { get; set; }

    public string? ConveyorRef { get; set; }

    public int DestinationId { get; set; }

    public string Name { get; set; } = null!;

    public Guid? CellId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Cell1? Cell { get; set; }

    public virtual DestinationState? DestinationState { get; set; }

    public virtual ICollection<DestinationsDestinationCategory> DestinationsDestinationCategories { get; set; } = new List<DestinationsDestinationCategory>();

    public virtual ICollection<OutboundCarton> OutboundCartons { get; set; } = new List<OutboundCarton>();

    public virtual ICollection<Outbound> Outbounds { get; set; } = new List<Outbound>();

    public virtual ICollection<Endpoint1> Endpoints { get; set; } = new List<Endpoint1>();

    public virtual ICollection<MeteringGroup> MeteringGroups { get; set; } = new List<MeteringGroup>();
}
