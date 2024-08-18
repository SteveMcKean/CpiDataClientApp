using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class HoldState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lpn> Lpns { get; set; } = new List<Lpn>();

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
