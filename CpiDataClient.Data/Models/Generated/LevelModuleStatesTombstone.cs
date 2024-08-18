using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LevelModuleStatesTombstone
{
    public int LevelModleStatesTombstoneSk { get; set; }

    public Guid Id { get; set; }

    public int State { get; set; }

    public DateTimeOffset? OpeningTime { get; set; }

    public DateTimeOffset? OpenedTime { get; set; }

    public DateTimeOffset? ClosingTime { get; set; }

    public DateTimeOffset? ClosingSecuredTime { get; set; }

    public DateTimeOffset? ClosedTime { get; set; }

    public DateTimeOffset? FaultedTime { get; set; }

    public DateTimeOffset? LastUpdateTime { get; set; }

    public int? StateReasonId { get; set; }

    public bool Enabled { get; set; }

    public Guid LevelId { get; set; }

    public Guid ModuleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime TombstoneDate { get; set; }

    public string? StateNote { get; set; }
}
