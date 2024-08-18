using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwUnavailableStructureResource
{
    public Guid Id { get; set; }

    public string ResourceType { get; set; } = null!;

    public string? ResourceName { get; set; }

    public string ResourceState { get; set; } = null!;

    public DateTimeOffset? StateChangedDateTime { get; set; }

    public string? StateReason { get; set; }

    public string? StateReasonNote { get; set; }

    public int? StructureStateReasonId { get; set; }
}
