using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class HealthMonitor
{
    public int Id { get; set; }

    public string CounterName { get; set; } = null!;

    public bool Value { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
