using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InventoryItemType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
