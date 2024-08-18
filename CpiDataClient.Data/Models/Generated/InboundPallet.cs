using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundPallet
{
    public int RecordNumber { get; set; }

    public Guid Id { get; set; }

    public DateTimeOffset? AddedTime { get; set; }

    public DateTimeOffset? ScannedTime { get; set; }

    public DateTimeOffset? DepalletizingStartedTime { get; set; }

    public DateTimeOffset? DepalletizingCompletedTime { get; set; }

    public DateTimeOffset? CanceledTime { get; set; }

    public DateTimeOffset? RejectedTime { get; set; }

    public int InboundPalletNumber { get; set; }

    public int LayersExpected { get; set; }

    public int LayersReceived { get; set; }

    public int StoredState { get; set; }

    public int PalletState { get; set; }

    public int DepalletizingSubState { get; set; }

    public int DeliveryState { get; set; }

    public int PartialPalletState { get; set; }

    public int LabelingSubState { get; set; }

    public int AlternatePrintingState { get; set; }

    public int DepalletizerOperationalMode { get; set; }

    public int? DepalletizingRejectionReason { get; set; }

    public short DepalletizerId { get; set; }

    public string? PickupLocation { get; set; }

    public DateTimeOffset? RotationDate { get; set; }

    public string? ParentLpn { get; set; }

    public string? InductionType { get; set; }

    public int? PalletType { get; set; }

    public bool IsOnHold { get; set; }

    public bool IsTestPallet { get; set; }

    public int? PalletBaseTypeId { get; set; }

    public DateTimeOffset? ReportedTime { get; set; }

    public int InboundPalletSourceId { get; set; }

    public bool IsTopLayerPartial { get; set; }

    public virtual InboundPalletAlternatePrintingState AlternatePrintingStateNavigation { get; set; } = null!;

    public virtual PalletDeliveryState DeliveryStateNavigation { get; set; } = null!;

    public virtual DepalletizerOperationalMode DepalletizerOperationalModeNavigation { get; set; } = null!;

    public virtual DepalletizingRejectionReason? DepalletizingRejectionReasonNavigation { get; set; }

    public virtual DepalletizingSubState DepalletizingSubStateNavigation { get; set; } = null!;

    public virtual Inbound IdNavigation { get; set; } = null!;

    public virtual InboundPalletSource InboundPalletSource { get; set; } = null!;

    public virtual InboundPalletLabelingSubState LabelingSubStateNavigation { get; set; } = null!;

    public virtual PalletBaseType? PalletBaseType { get; set; }

    public virtual ICollection<PalletLayer> PalletLayers { get; set; } = new List<PalletLayer>();

    public virtual InboundPalletState PalletStateNavigation { get; set; } = null!;

    public virtual MultiPalletType? PalletTypeNavigation { get; set; }

    public virtual PartialPalletState PartialPalletStateNavigation { get; set; } = null!;

    public virtual InboundPalletStoredState StoredStateNavigation { get; set; } = null!;
}
