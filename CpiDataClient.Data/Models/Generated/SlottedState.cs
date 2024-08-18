using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SlottedState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
