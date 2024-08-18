using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SubsystemServiceStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Subsystem1> Subsystem1s { get; set; } = new List<Subsystem1>();
}
