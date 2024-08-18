using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferLocation1
{
    public int Id { get; set; }

    public int CartonLiftId { get; set; }

    public int? VerticalTransferBufferGroupId { get; set; }

    public string? Type { get; set; }

    public int? InboundX { get; set; }

    public int? InboundY { get; set; }

    public int? OutboundX { get; set; }

    public int? OutboundY { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
