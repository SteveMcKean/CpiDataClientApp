using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShelfState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ShelveState> ShelveStates { get; set; } = new List<ShelveState>();
}
