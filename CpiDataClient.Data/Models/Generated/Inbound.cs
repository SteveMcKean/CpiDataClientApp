using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Inbound
{
    public Guid Id { get; set; }

    public string CustomerInboundRef { get; set; } = null!;

    public string? CustomerCartonGroupRef { get; set; }

    public int CartonsExpected { get; set; }

    public int CartonsReceived { get; set; }

    public int CartonsStored { get; set; }

    public DateTimeOffset? CartonsStoredTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual InboundBatch? InboundBatch { get; set; }

    public virtual ICollection<InboundCarton> InboundCartons { get; set; } = new List<InboundCarton>();

    public virtual ICollection<InboundForecast> InboundForecasts { get; set; } = new List<InboundForecast>();

    public virtual InboundPallet? InboundPallet { get; set; }
}
