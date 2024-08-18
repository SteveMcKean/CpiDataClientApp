using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLiftState
{
    public Guid Id { get; set; }

    public int State { get; set; }

    public int StopReason { get; set; }

    public DateTimeOffset? StartingTime { get; set; }

    public DateTimeOffset? StartedTime { get; set; }

    public DateTimeOffset? StoppingTime { get; set; }

    public DateTimeOffset? StoppedTime { get; set; }

    public DateTimeOffset? AbortingTime { get; set; }

    public DateTimeOffset? AbortedTime { get; set; }

    public DateTimeOffset? ResettingTime { get; set; }

    public DateTimeOffset? LastUpdateTime { get; set; }

    public Guid CartonLiftId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public bool IsEnabled { get; set; }

    public virtual CartonLift1 CartonLift { get; set; } = null!;

    public virtual CartonLiftTransitionState StateNavigation { get; set; } = null!;

    public virtual CartonLiftStopReason StopReasonNavigation { get; set; } = null!;
}
