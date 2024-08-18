using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundBatch1
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

    public Guid SessionKey { get; set; }
}
