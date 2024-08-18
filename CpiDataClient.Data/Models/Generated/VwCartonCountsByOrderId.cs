using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonCountsByOrderId
{
    public Guid OrderId { get; set; }

    public int? Unknown { get; set; }

    public int? Allocated { get; set; }

    public int? Assigned { get; set; }

    public int? Sent { get; set; }

    public int? RoutedToDestination { get; set; }

    public int? Delivered { get; set; }

    public int? Palletized { get; set; }

    public int? Scratched { get; set; }

    public int? Reserved { get; set; }

    public int? Aborted { get; set; }
}
