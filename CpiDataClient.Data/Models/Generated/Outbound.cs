using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Outbound
{
    public Guid Id { get; set; }

    public int OutboundDestination { get; set; }

    public int DestinationGroup { get; set; }

    public int State { get; set; }

    public int GroupCount { get; set; }

    public Guid OrderId { get; set; }

    public Guid? DestinationId { get; set; }

    public bool IsPlaceholder { get; set; }

    public int ChildOutboundTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();

    public virtual ChildOutboundType ChildOutboundType { get; set; } = null!;

    public virtual Destination? Destination { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual OutboundBatch? OutboundBatch { get; set; }

    public virtual OutboundDestination OutboundDestinationNavigation { get; set; } = null!;

    public virtual ICollection<OutboundExtension> OutboundExtensions { get; set; } = new List<OutboundExtension>();

    public virtual OutboundLabel? OutboundLabel { get; set; }

    public virtual OutboundPallet? OutboundPallet { get; set; }

    public virtual OutboundParentChildMap? OutboundParentChildMapChild { get; set; }

    public virtual ICollection<OutboundParentChildMap> OutboundParentChildMapParents { get; set; } = new List<OutboundParentChildMap>();

    public virtual OutboundState StateNavigation { get; set; } = null!;
}
