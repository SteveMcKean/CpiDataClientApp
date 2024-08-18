using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOutboundPallet
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

    public int OutboundDestination { get; set; }

    public int DestinationGroup { get; set; }

    public int State { get; set; }

    public int GroupCount { get; set; }

    public Guid OrderId { get; set; }

    public Guid? DestinationId { get; set; }
}
