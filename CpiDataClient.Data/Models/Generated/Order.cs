using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Order
{
    public Guid Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int SequenceIndex { get; set; }

    public int SequenceCount { get; set; }

    public int OrderTypeId { get; set; }

    public int StopSequence { get; set; }

    public int State { get; set; }

    public DateTimeOffset LatestDeliveryTime { get; set; }

    public DateTimeOffset ProposedGateTime { get; set; }

    public DateTimeOffset EarliestDeliveryTime { get; set; }

    public int MaxPalletCube { get; set; }

    public int BatchIndex { get; set; }

    public Guid OrderBatchId { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerChainNumber { get; set; }

    public int PlanState { get; set; }

    public int PlannedNotifyState { get; set; }

    public int PlanUpdatedNotifyState { get; set; }

    public int CompletedNotifyState { get; set; }

    public int CaseStorageNotifyState { get; set; }

    public int HoldState { get; set; }

    public DateTimeOffset? PlanningCompletedTime { get; set; }

    public DateTimeOffset? ProcessingStartedTime { get; set; }

    public DateTimeOffset? ProcessingCompletedTime { get; set; }

    public DateTimeOffset? CanceledTime { get; set; }

    public DateTimeOffset? PurgeDeadlineTime { get; set; }

    public long MaxCubicVolume { get; set; }

    public double ReverseStopSequence { get; set; }

    public int FirstAvailablePalletId { get; set; }

    public int Priority { get; set; }

    public string? TruckRoute { get; set; }

    public int SelectionMode { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public DateTimeOffset? ClosedTime { get; set; }

    public DateTimeOffset LastModifiedTime { get; set; }

    public string? DoorNumber { get; set; }

    public string? TrailerNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public bool IsInternal { get; set; }

    public string? CustomerName { get; set; }

    public Guid? ParentOrderId { get; set; }

    public bool IsChaseEligible { get; set; }

    public bool RequiresResolution { get; set; }

    public int? OrderCancelSourceId { get; set; }

    public bool IsTest { get; set; }

    public string? CellGroup { get; set; }

    public virtual NotifyState CaseStorageNotifyStateNavigation { get; set; } = null!;

    public virtual NotifyState CompletedNotifyStateNavigation { get; set; } = null!;

    public virtual OrderHoldState HoldStateNavigation { get; set; } = null!;

    public virtual ICollection<Order> InverseParentOrder { get; set; } = new List<Order>();

    public virtual OrderBatch OrderBatch { get; set; } = null!;

    public virtual OrderCancelSource? OrderCancelSource { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OrderExtension> OrderExtensions { get; set; } = new List<OrderExtension>();

    public virtual OrderType OrderType { get; set; } = null!;

    public virtual ICollection<Outbound> Outbounds { get; set; } = new List<Outbound>();

    public virtual Order? ParentOrder { get; set; }

    public virtual OrderPlanState PlanStateNavigation { get; set; } = null!;

    public virtual NotifyState PlanUpdatedNotifyStateNavigation { get; set; } = null!;

    public virtual NotifyState PlannedNotifyStateNavigation { get; set; } = null!;

    public virtual ExpirationSelectionMode SelectionModeNavigation { get; set; } = null!;

    public virtual OrderState StateNavigation { get; set; } = null!;
}
