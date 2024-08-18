using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TaskPlanCartonsTombstone
{
    public int TaskPlanCtnsTombstoneSk { get; set; }

    public Guid Id { get; set; }

    public int Position { get; set; }

    public Guid TaskPlanId { get; set; }

    public Guid CartonId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime TombstoneDate { get; set; }
}
