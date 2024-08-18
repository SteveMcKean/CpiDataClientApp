using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonCountsByOrderIdSkuIdPalletId
{
    public Guid OrderId { get; set; }

    public Guid? SkuId { get; set; }

    public Guid PalletId { get; set; }

    public int? TotalCartons { get; set; }

    public int? UnknownCartons { get; set; }

    public int? AllocatedCartons { get; set; }

    public int? AssignedCartons { get; set; }

    public int? SentCartons { get; set; }

    public int? DeliveredCartons { get; set; }

    public int? PalletizedCartons { get; set; }

    public int? ScratchedCartons { get; set; }

    public int? RoutedToDestinationCartons { get; set; }

    public int? ReservedCartons { get; set; }

    public int? TotalEaches { get; set; }

    public int? UnknownEaches { get; set; }

    public int? AllocatedEaches { get; set; }

    public int? AssignedEaches { get; set; }

    public int? SentEaches { get; set; }

    public int? DeliveredEaches { get; set; }

    public int? PalletizedEaches { get; set; }

    public int? ScratchedEaches { get; set; }

    public int? RoutedToDestinationEaches { get; set; }

    public int? ReservedEaches { get; set; }
}
