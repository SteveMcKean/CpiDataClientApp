using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ExpirationSelectionMode
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
