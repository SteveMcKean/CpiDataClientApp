using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PickupAndDeliveryStation1
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid ModuleId { get; set; }

    public int Direction { get; set; }

    public int GroupId { get; set; }

    public string CellName { get; set; } = null!;

    public int Number { get; set; }

    public int Type { get; set; }

    public Guid? AisleId { get; set; }

    public virtual Aisle1? Aisle { get; set; }

    public virtual PickupAndDeliveryStationDirection DirectionNavigation { get; set; } = null!;

    public virtual Endpoint1 IdNavigation { get; set; } = null!;

    public virtual Module1 Module { get; set; } = null!;

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();

    public virtual PickupAndDeliveryStationType TypeNavigation { get; set; } = null!;
}
