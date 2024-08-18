using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkuActivityOutboundPallet
{
    public Guid? Id { get; set; }

    public DateTimeOffset LastModifiedTime { get; set; }

    public Guid OrderBatchId { get; set; }

    public string CustomerBatchRef { get; set; } = null!;

    public int WaveNumber { get; set; }

    public string OrderNumber { get; set; } = null!;

    public Guid? SkuId { get; set; }

    public string Sku { get; set; } = null!;

    public string? SkuName { get; set; }

    public string? CustomerPalletNumber { get; set; }

    public int OutboundPalletNumber { get; set; }

    public string? Lpn { get; set; }

    public int? TotalCartons { get; set; }

    public int? AllocatedCartons { get; set; }

    public int? AssignedCartons { get; set; }

    public int? SentCartons { get; set; }

    public int? DeliveredCartons { get; set; }

    public int? PalletizedCartons { get; set; }

    public int? ScratchedCartons { get; set; }

    public int? RoutedToDestinationCartons { get; set; }

    public int? UnknownCartons { get; set; }

    public int? TotalEaches { get; set; }

    public int? AssignedEaches { get; set; }

    public int? AllocatedEaches { get; set; }

    public int? SentEaches { get; set; }

    public int? DeliveredEaches { get; set; }

    public int? PalletizedEaches { get; set; }

    public int? ScratchedEaches { get; set; }

    public int? RoutedToDestinationEaches { get; set; }

    public int? UnknownEaches { get; set; }

    public Guid OrderId { get; set; }

    public Guid PalletId { get; set; }

    public int? ReservedCartons { get; set; }

    public int? ReservedEaches { get; set; }

    public DateTime ModifiedDate { get; set; }
}
