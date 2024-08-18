using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AisleType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Aisle1> Aisle1s { get; set; } = new List<Aisle1>();
}
