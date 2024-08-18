using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShelveState
{
    public Guid Id { get; set; }

    public int State { get; set; }

    public DateTimeOffset StateChangeDateTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? StateReasonId { get; set; }

    public string? StateNote { get; set; }

    public virtual Shelf1 IdNavigation { get; set; } = null!;

    public virtual ShelfState StateNavigation { get; set; } = null!;

    public virtual StructureStateReason? StateReason { get; set; }
}
