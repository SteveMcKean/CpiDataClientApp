using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOutboundPalletSummary
{
    public Guid Id { get; set; }

    public string? CustomerPalletNumber { get; set; }

    public string? LicensePlateNumber { get; set; }

    public int OutboundPalletNumber { get; set; }

    public double StopNumber { get; set; }

    public DateTimeOffset? ActualStartTime { get; set; }

    public DateTimeOffset? CompletedTime { get; set; }

    public DateTimeOffset? DeliveredTime { get; set; }

    public int PalletType { get; set; }

    public int PalletBaseTypeId { get; set; }

    public int PalletizingSubState { get; set; }

    public int PalletState { get; set; }

    public string CustomerBatchRef { get; set; } = null!;

    public string? TruckRoute { get; set; }

    public int OrderTypeId { get; set; }

    public string? CustomerName { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int OrderHoldState { get; set; }

    public int WaveNumber { get; set; }

    public int? CartonsTotal { get; set; }

    public int? CartonsStateUnknown { get; set; }

    public int? CartonsAllocated { get; set; }

    public int? CartonsAssigned { get; set; }

    public int? CartonsSent { get; set; }

    public int? CartonsRoutedToDestination { get; set; }

    public int? CartonsDelivered { get; set; }

    public int? CartonsOnPallet { get; set; }

    public int? CartonsScratched { get; set; }

    public int? CartonsReserved { get; set; }

    public int? UnknownEaches { get; set; }

    public int? AllocatedEaches { get; set; }

    public int? AssignedEaches { get; set; }

    public int? SentEaches { get; set; }

    public int? DeliveredEaches { get; set; }

    public int? PalletizedEaches { get; set; }

    public int? ScratchedEaches { get; set; }

    public int? ReservedEaches { get; set; }

    public int? RoutedToDestinationEaches { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string PalletBuiltBy { get; set; } = null!;

    public Guid? DestinationId { get; set; }

    public string? DestinationName { get; set; }

    public int? DestinationNumber { get; set; }
}
