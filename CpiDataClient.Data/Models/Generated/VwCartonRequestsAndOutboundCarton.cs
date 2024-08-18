using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonRequestsAndOutboundCarton
{
    public Guid CartonRequestId { get; set; }

    public Guid OutboundCartonId { get; set; }

    public string? DestinationName { get; set; }

    public int? DestinationNumber { get; set; }

    public Guid OrderId { get; set; }

    public int OutboundState { get; set; }

    public int? DestinationGroup { get; set; }

    public string CartonAvailabilitySelectionModeName { get; set; } = null!;

    public string CartonSelectionMode { get; set; } = null!;

    public string LpnSelectionModeName { get; set; } = null!;

    public string? Lpn { get; set; }

    public Guid? DestinationId { get; set; }

    public int DeliveryState { get; set; }

    public int? Eaches { get; set; }

    public int? Vcp { get; set; }

    public int? Ssp { get; set; }

    public Guid? SkuId { get; set; }

    public Guid? LpnId { get; set; }

    public Guid OutboundId { get; set; }

    public DateTimeOffset? DeliveryStateChangeTime { get; set; }

    public int? ScratchReason { get; set; }

    public int CartonType { get; set; }

    public bool? TrapFlag { get; set; }

    public bool CanUseExpired { get; set; }

    public bool UseAvailableOnly { get; set; }

    public int? TrapPromotionNumber { get; set; }

    public int? AppointmentNumber { get; set; }

    public int? Ponumber { get; set; }

    public string? CustomerCartonRef { get; set; }

    public int GroupNumber { get; set; }

    public int? ExpirationWindow { get; set; }

    public int SequenceNumber { get; set; }

    public int CartonTypeSelectionMode { get; set; }

    public int LpnSelectionMode { get; set; }

    public DateTimeOffset? OnBotTime { get; set; }

    public DateTimeOffset? OnCartonLiftTime { get; set; }

    public DateTimeOffset? OnConveyorTime { get; set; }

    public DateTimeOffset? RoutedToDestinationTime { get; set; }

    public DateTimeOffset? DeliveredTime { get; set; }

    public DateTimeOffset? PalletizedTime { get; set; }

    public DateTimeOffset? PurgedTime { get; set; }

    public int? ExpirationOffset { get; set; }

    public int CartonAvailabilitySelectionMode { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public string? SourceFacility { get; set; }

    public string? Batch { get; set; }

    public int? AllocationPoolType { get; set; }

    public int? RejectReason { get; set; }

    public DateTimeOffset? RejectedTime { get; set; }

    public Guid OrderDetailId { get; set; }

    public int? ContainerTypeId { get; set; }

    public DateTime ModifiedDate { get; set; }
}
