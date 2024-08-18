using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkuActivityOutboundDestination
{
    public Guid? Id { get; set; }

    public string CustomerBatchRef { get; set; } = null!;

    public int WaveNumber { get; set; }

    public Guid OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public Guid SkuId { get; set; }

    public string? SkuName { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public string? DestinationName { get; set; }

    public string? DestinationCustomerRef { get; set; }

    public string? DestinationConveyorRef { get; set; }

    public Guid? DestinationId { get; set; }

    public int? DestinationGroup { get; set; }

    public int TotalCartons { get; set; }

    public int AllocatedCartons { get; set; }

    public int AssignedCartons { get; set; }

    public int SentCartons { get; set; }

    public int DeliveredCartons { get; set; }

    public int PalletizedCartons { get; set; }

    public int ScratchedCartons { get; set; }

    public int ReservedCartons { get; set; }

    public int RoutedToDestinationCartons { get; set; }

    public int UnknownCartons { get; set; }

    public int TotalEaches { get; set; }

    public int AllocatedEaches { get; set; }

    public int AssignedEaches { get; set; }

    public int SentEaches { get; set; }

    public int DeliveredEaches { get; set; }

    public int PalletizedEaches { get; set; }

    public int ScratchedEaches { get; set; }

    public int RoutedToDestinationEaches { get; set; }

    public int ReservedEaches { get; set; }

    public int UnknownEaches { get; set; }

    public DateTime ModifiedDate { get; set; }
}
