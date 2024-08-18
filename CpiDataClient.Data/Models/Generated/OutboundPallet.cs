using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundPallet
{
    public Guid Id { get; set; }

    public int OutboundPalletNumber { get; set; }

    public int BuildMode { get; set; }

    public string? PlannedPalletFileName { get; set; }

    public string? SequenceFileName { get; set; }

    public string? PalletResultFileName { get; set; }

    public string? PickupLocation { get; set; }

    public string? Lpn { get; set; }

    public long Volume { get; set; }

    public int? PalletizerId { get; set; }

    public DateTimeOffset? DeliveredTime { get; set; }

    public int BuildResult { get; set; }

    public DateTimeOffset? BuiltTime { get; set; }

    public DateTimeOffset? CompletedTime { get; set; }

    public int DeliveredState { get; set; }

    public int PalletizingSubState { get; set; }

    public int? ParentPalletId { get; set; }

    public int NotifiedState { get; set; }

    public bool WasAdditionalPalletNeeded { get; set; }

    public int LabelingSubState { get; set; }

    public int AlternatePrintingState { get; set; }

    public int PalletType { get; set; }

    public bool PalletTypeOverridden { get; set; }

    public string? CustomerPalletNumber { get; set; }

    public int PalletBaseTypeId { get; set; }

    public int PalletSequenceNumber { get; set; }

    public DateTimeOffset? ActualStartTime { get; set; }

    public double StopNumber { get; set; }

    public int PalletBuiltById { get; set; }

    public int? ManualBuildReasonId { get; set; }

    public int? DepartmentLayeringPercent { get; set; }

    public virtual OutboundPalletAlternatePrintingState AlternatePrintingStateNavigation { get; set; } = null!;

    public virtual OperationalMode BuildModeNavigation { get; set; } = null!;

    public virtual PalletPalletizingResult BuildResultNavigation { get; set; } = null!;

    public virtual OutboundPalletDeliveredState DeliveredStateNavigation { get; set; } = null!;

    public virtual Outbound IdNavigation { get; set; } = null!;

    public virtual OutboundPalletLabelingSubState LabelingSubStateNavigation { get; set; } = null!;

    public virtual ManualBuildReason? ManualBuildReason { get; set; }

    public virtual OutboundPalletNotifyState NotifiedStateNavigation { get; set; } = null!;

    public virtual PalletBaseType PalletBaseType { get; set; } = null!;

    public virtual PalletBuiltBy PalletBuiltBy { get; set; } = null!;

    public virtual PalletType PalletTypeNavigation { get; set; } = null!;

    public virtual PalletizingSubState PalletizingSubStateNavigation { get; set; } = null!;

    public virtual ICollection<ReplenishmentTask> ReplenishmentTasks { get; set; } = new List<ReplenishmentTask>();
}
