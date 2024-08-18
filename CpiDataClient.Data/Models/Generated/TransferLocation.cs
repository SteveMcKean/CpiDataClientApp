using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferLocation
{
    public int Id { get; set; }

    public int CartonLiftId { get; set; }

    public int? VerticalTransferBufferGroupId { get; set; }

    public string? Type { get; set; }

    public int? InboundX { get; set; }

    public int? InboundY { get; set; }

    public string? OutboundX { get; set; }

    public int? OutboundY { get; set; }
}
