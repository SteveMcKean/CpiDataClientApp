using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOrderSummary
{
    public Guid OrderId { get; set; }

    public Guid OrderDetailId { get; set; }

    public Guid CartonRequestId { get; set; }

    public int DeliveryState { get; set; }
}
