using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonAvailabilityCartonStateJunction
{
    public int CartonAvailabilityId { get; set; }

    public string CartonAvailabilityName { get; set; } = null!;

    public int CartonStateId { get; set; }

    public string CartonStateName { get; set; } = null!;

    public int IsCartonAvailable { get; set; }
}
