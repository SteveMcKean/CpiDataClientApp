using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PickupAndDeliveryStationDirection
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PickupAndDeliveryStation1> PickupAndDeliveryStation1s { get; set; } = new List<PickupAndDeliveryStation1>();
}
