using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLiftTransitionState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CartonLiftState> CartonLiftStates { get; set; } = new List<CartonLiftState>();
}
