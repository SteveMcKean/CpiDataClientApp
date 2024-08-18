using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOutboundCartonActivity
{
    public Guid? Id { get; set; }

    public Guid OutboundCartonId { get; set; }

    public Guid OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public string? Lpn { get; set; }

    public int? Ponumber { get; set; }

    public int? AppointmentNumber { get; set; }

    public string OrderTypeName { get; set; } = null!;

    public int OrderTypeId { get; set; }

    public string OrderStateName { get; set; } = null!;

    public string? CustomerNumber { get; set; }

    public string? CustomerChainNumber { get; set; }

    public int ExpirationSelectionMode { get; set; }

    public string DeliveryStateName { get; set; } = null!;

    public string? DestinationName { get; set; }

    public int? DestinationGroup { get; set; }

    public int? Eaches { get; set; }

    public int? Vcp { get; set; }

    public int? Ssp { get; set; }

    public string? Sku { get; set; }

    public string? SkuName { get; set; }

    public string? SkuDescription { get; set; }

    public string? ScratchReasonName { get; set; }

    public int? ScratchReason { get; set; }

    public int? TrapPromotionNumber { get; set; }

    public bool? TrapFlag { get; set; }

    public bool CanUseExpired { get; set; }

    public string? CustomerCartonRef { get; set; }

    public int GroupNumber { get; set; }

    public int? ExpirationWindow { get; set; }

    public string CartonSelectionMode { get; set; } = null!;

    public int LpnSelectionMode { get; set; }

    public string LpnSelectionModeName { get; set; } = null!;

    public DateTimeOffset? OnBotTime { get; set; }

    public DateTimeOffset? OnCartonLiftTime { get; set; }

    public DateTimeOffset? OnConveyorTime { get; set; }

    public int DeliveryState { get; set; }

    public DateTimeOffset? DeliveredTime { get; set; }

    public DateTimeOffset? DeliveryStateChangeTime { get; set; }

    public DateTimeOffset? PalletizedTime { get; set; }

    public DateTimeOffset? PurgedTime { get; set; }

    public int? ExpirationOffset { get; set; }

    public int CartonAvailabilitySelectionMode { get; set; }

    public DateTimeOffset? RoutedToDestinationTime { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int? DestinationNumber { get; set; }

    public Guid CartonRequestId { get; set; }

    public int SequenceNumber { get; set; }

    public int CartonTypeSelectionMode { get; set; }

    public int? ContainerTypeId { get; set; }

    public int CartonType { get; set; }

    public int QuantityType { get; set; }

    public int OutboundState { get; set; }

    public Guid? SkuId { get; set; }

    public string? SubstituteSku { get; set; }

    public string? SubstituteSkuName { get; set; }

    public string? SubstituteSkuDescription { get; set; }

    public DateTime ModifiedDate { get; set; }
}
