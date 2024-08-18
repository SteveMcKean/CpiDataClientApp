using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonLabel
{
    public Guid Id { get; set; }

    public DateTime LastPrinted { get; set; }

    public string Lpn { get; set; } = null!;

    public string CustomerCartonRef { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Description { get; set; }

    public string? Upc { get; set; }

    public string UserName { get; set; } = null!;

    public string Direction { get; set; } = null!;

    public string? Destination { get; set; }

    public Guid CartonLabelId { get; set; }

    public Guid? LpnId { get; set; }

    public Guid? UpcId { get; set; }

    public Guid SkuId { get; set; }

    public int? DirectionId { get; set; }

    public Guid CartonId { get; set; }

    public Guid? DestinationId { get; set; }

    public int? SequenceNumber { get; set; }
}
