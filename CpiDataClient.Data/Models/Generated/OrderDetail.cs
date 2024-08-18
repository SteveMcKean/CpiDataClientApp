using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderDetail
{
    public Guid Id { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerChainNumber { get; set; }

    public string? SpogNumber { get; set; }

    public int Quantity { get; set; }

    public int QuantityType { get; set; }

    public int CartonType { get; set; }

    public int? Vcp { get; set; }

    public int? Ssp { get; set; }

    public bool? TrapFlag { get; set; }

    public int? TrapPromotionNumber { get; set; }

    public int? AppointmentNumber { get; set; }

    public int? Ponumber { get; set; }

    public string? CustomerCartonRef { get; set; }

    public Guid OrderId { get; set; }

    public Guid? SkuId { get; set; }

    public Guid? LpnId { get; set; }

    public int OrderDestination { get; set; }

    public bool CanUseExpired { get; set; }

    public bool UseAvailableOnly { get; set; }

    public int? ExpirationWindow { get; set; }

    public Guid? DestinationCategoryId { get; set; }

    public string? CustomerTaskId { get; set; }

    public int LpnSelectionMode { get; set; }

    public string? GroupId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int ExpirationOffset { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int CartonAvailabilitySelectionMode { get; set; }

    public int? PalletBaseTypeId { get; set; }

    public string? CustomerRef { get; set; }

    public int ExpirationSelectionMode { get; set; }

    public bool UseQuarantinedSuspects { get; set; }

    public bool UseSubstituteSkus { get; set; }

    public int FulfilledById { get; set; }

    public int? LabelTypeId { get; set; }

    public bool? LabelTypeInclusivity { get; set; }

    public int? OutboundDestinationId { get; set; }

    public int ContainerType { get; set; }

    public int Eaches { get; set; }

    public virtual ICollection<CandidateCaseGroupNumber> CandidateCaseGroupNumbers { get; set; } = new List<CandidateCaseGroupNumber>();

    public virtual ICollection<CandidateCustomerCartonRef> CandidateCustomerCartonRefs { get; set; } = new List<CandidateCustomerCartonRef>();

    public virtual CartonAvailabilitySelectionMode CartonAvailabilitySelectionModeNavigation { get; set; } = null!;

    public virtual ICollection<CartonLabel> CartonLabels { get; set; } = new List<CartonLabel>();

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();

    public virtual OrderCartonType CartonTypeNavigation { get; set; } = null!;

    public virtual ContainerType ContainerTypeNavigation { get; set; } = null!;

    public virtual DestinationCategory? DestinationCategory { get; set; }

    public virtual FulfilledBy FulfilledBy { get; set; } = null!;

    public virtual LabelType? LabelType { get; set; }

    public virtual Lpn? Lpn { get; set; }

    public virtual LpnSelectionMode LpnSelectionModeNavigation { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual OrderDestination OrderDestinationNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetailExtension> OrderDetailExtensions { get; set; } = new List<OrderDetailExtension>();

    public virtual PalletBaseType? PalletBaseType { get; set; }

    public virtual QuantityType QuantityTypeNavigation { get; set; } = null!;

    public virtual Sku? Sku { get; set; }
}
