using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundOrderSummary
{
    public Guid? Id { get; set; }

    public Guid OrderId { get; set; }

    public string CustomerBatchRef { get; set; } = null!;

    public Guid BatchId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int OrderHoldState { get; set; }

    public int WaveNumber { get; set; }

    public int OrderPriority { get; set; }

    public int OrderTypeId { get; set; }

    public string OrderTypeDisplayName { get; set; } = null!;

    public string OrderTypeName { get; set; } = null!;

    public int OrderExpirationSelectionMode { get; set; }

    public double ReverseStopSequence { get; set; }

    public string? TruckRoute { get; set; }

    public string? DoorNumber { get; set; }

    public string? TrailerNumber { get; set; }

    public DateTimeOffset OrderCreatedTime { get; set; }

    public DateTimeOffset LastModifiedTime { get; set; }

    public DateTimeOffset? ProcessingCompletedTime { get; set; }

    public DateTimeOffset? ProcessingStartedTime { get; set; }

    public bool CanManualCancel { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int SequenceIndex { get; set; }

    public int SequenceCount { get; set; }

    public int StopSequence { get; set; }

    public int State { get; set; }

    public DateTimeOffset LatestDeliveryTime { get; set; }

    public DateTimeOffset EarliestDeliveryTime { get; set; }

    public int MaxPalletCube { get; set; }

    public int BatchIndex { get; set; }

    public Guid OrderBatchId { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerChainNumber { get; set; }

    public int PlanState { get; set; }

    public int HoldState { get; set; }

    public DateTimeOffset? PlanningCompletedTime { get; set; }

    public DateTimeOffset? CanceledTime { get; set; }

    public int? BatchPriority { get; set; }

    public int? NonSymboticHeavyCaseCount { get; set; }

    public int? NonSymboticLightCaseCount { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public DateTimeOffset? ClosedTime { get; set; }

    public int TotalCartons { get; set; }

    public int UnknownCartons { get; set; }

    public int AllocatedCartons { get; set; }

    public int AssignedCartons { get; set; }

    public int SentCartons { get; set; }

    public int DeliveredCartons { get; set; }

    public int PalletizedCartons { get; set; }

    public int ScratchedCartons { get; set; }

    public int RoutedToDestinationCartons { get; set; }

    public int ReservedCartons { get; set; }

    public int AbortedCartons { get; set; }

    public int PalletSourceType { get; set; }

    public bool? HasOrderTotes { get; set; }

    public int TotalToteCount { get; set; }

    public int SupplyToteCount { get; set; }

    public int OrderToteCount { get; set; }

    public bool RequiresResolution { get; set; }

    public bool IsTest { get; set; }
}
