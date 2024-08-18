using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShiftState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();
}
