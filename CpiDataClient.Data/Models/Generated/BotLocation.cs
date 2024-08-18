using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotLocation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<BotWarehouseState> BotWarehouseStates { get; set; } = new List<BotWarehouseState>();
}
