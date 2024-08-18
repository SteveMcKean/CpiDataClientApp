using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();
}
