using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonRequest
{
    public Guid Id { get; set; }

    public int SequenceNumber { get; set; }

    public int DeliveryState { get; set; }

    public DateTimeOffset? DeliveryStateChangeTime { get; set; }

    public int? ScratchReason { get; set; }

    public int CartonType { get; set; }

    public int? Eaches { get; set; }

    public int? Vcp { get; set; }

    public int? Ssp { get; set; }

    public bool? TrapFlag { get; set; }

    public bool CanUseExpired { get; set; }

    public bool UseAvailableOnly { get; set; }

    public int? TrapPromotionNumber { get; set; }

    public int? AppointmentNumber { get; set; }

    public int? Ponumber { get; set; }

    public string? CustomerCartonRef { get; set; }

    public int GroupNumber { get; set; }

    public int? ExpirationWindow { get; set; }

    public int CartonTypeSelectionMode { get; set; }

    public Guid? SkuId { get; set; }

    public Guid? LpnId { get; set; }

    public Guid? OrderDetailId { get; set; }

    public int LpnSelectionMode { get; set; }

    public Guid OutboundId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public Guid? OutboundDimensionalVariantId { get; set; }

    public int? ExpirationOffset { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int CartonAvailabilitySelectionMode { get; set; }

    public int? AllocationPoolType { get; set; }

    public DateTimeOffset? CartonExpirationDate { get; set; }

    public bool UseQuarantinedSuspects { get; set; }

    public bool UseSubstituteSkus { get; set; }

    public int PickfaceGroupId { get; set; }

    public int PickfaceCaseOrientation { get; set; }

    public int? LabelTypeId { get; set; }

    public bool? LabelTypeInclusivity { get; set; }

    public int ContainerType { get; set; }

    public int? LayerNumber { get; set; }

    public virtual AllocationPoolType? AllocationPoolTypeNavigation { get; set; }

    public virtual CartonAvailabilitySelectionMode CartonAvailabilitySelectionModeNavigation { get; set; } = null!;

    public virtual CartonTypeSelectionMode CartonTypeSelectionModeNavigation { get; set; } = null!;

    public virtual ContainerType ContainerTypeNavigation { get; set; } = null!;

    public virtual DeliveryState DeliveryStateNavigation { get; set; } = null!;

    public virtual LabelType? LabelType { get; set; }

    public virtual Lpn? Lpn { get; set; }

    public virtual LpnSelectionMode LpnSelectionModeNavigation { get; set; } = null!;

    public virtual OrderDetail? OrderDetail { get; set; }

    public virtual Outbound Outbound { get; set; } = null!;

    public virtual OutboundDimensionalVariant? OutboundDimensionalVariant { get; set; }

    public virtual ScratchReason? ScratchReasonNavigation { get; set; }

    public virtual ICollection<SelectedCustomerCartonRef> SelectedCustomerCartonRefs { get; set; } = new List<SelectedCustomerCartonRef>();

    public virtual Sku? Sku { get; set; }

    public virtual ICollection<OutboundCarton> OutboundCartons { get; set; } = new List<OutboundCarton>();
}
