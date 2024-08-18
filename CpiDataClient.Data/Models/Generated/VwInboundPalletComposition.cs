using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInboundPalletComposition
{
    public DateTimeOffset? AddedTime { get; set; }

    public int? AlternatePrintingState { get; set; }

    public string? Batch { get; set; }

    public DateTimeOffset? CanceledTime { get; set; }

    public int CartonsExpected { get; set; }

    public int CartonsInducted { get; set; }

    public int CartonsRejected { get; set; }

    public int CartonsStored { get; set; }

    public DateTimeOffset? CartonsStoredTime { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public string? CustomerInboundRef { get; set; }

    public int? DeliveryState { get; set; }

    public short? DepalletizerId { get; set; }

    public int? DepalletizerOperationalMode { get; set; }

    public DateTimeOffset? DepalletizingCompletedTime { get; set; }

    public int? DepalletizingRejectionReason { get; set; }

    public DateTimeOffset? DepalletizingStartedTime { get; set; }

    public int? DepalletizingSubState { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public Guid? Id { get; set; }

    public Guid? InboundPalletId { get; set; }

    public int? InboundPalletNumber { get; set; }

    public string? InductionType { get; set; }

    public bool? IsOnHold { get; set; }

    public bool? IsTestPallet { get; set; }

    public DateTimeOffset? InductionDate { get; set; }

    public bool IsInternal { get; set; }

    public int? LabelingSubState { get; set; }

    public int? LayersExpected { get; set; }

    public int? LayersReceived { get; set; }

    public string LicensePlateNumber { get; set; } = null!;

    public int LpnHoldState { get; set; }

    public Guid Lpnid { get; set; }

    public DateTimeOffset? ScannedTime { get; set; }

    public int? PalletState { get; set; }

    public int? PalletType { get; set; }

    public int? PalletBaseTypeId { get; set; }

    public string? ParentLpn { get; set; }

    public int? PartialPalletState { get; set; }

    public string? PickupLocation { get; set; }

    public DateTimeOffset? RejectedTime { get; set; }

    public DateTimeOffset? RotationDate { get; set; }

    public string Sku { get; set; } = null!;

    public int SkuHoldState { get; set; }

    public Guid SkuId { get; set; }

    public string? SkuName { get; set; }

    public string? SkuDescription { get; set; }

    public string? SourceFacility { get; set; }

    public int? StoredState { get; set; }

    public DateTimeOffset? ReceivedDate { get; set; }
}
