using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Zone1
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public int Number { get; set; }

    public int SafetyZoneRef { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Aisle1> Aisle1s { get; set; } = new List<Aisle1>();

    public virtual ICollection<ZoneState> ZoneStates { get; set; } = new List<ZoneState>();
}
