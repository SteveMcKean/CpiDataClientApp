using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TaskPlanCarton
{
    public Guid Id { get; set; }

    public int Position { get; set; }

    public Guid TaskPlanId { get; set; }

    public Guid CartonId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Carton Carton { get; set; } = null!;

    public virtual TaskPlan TaskPlan { get; set; } = null!;
}
