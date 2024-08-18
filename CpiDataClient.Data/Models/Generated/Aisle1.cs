using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Aisle1
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public int StartPointX { get; set; }

    public int StartPointY { get; set; }

    public int EndPointX { get; set; }

    public int EndPointY { get; set; }

    public int Height { get; set; }

    public int Width { get; set; }

    public Guid LevelId { get; set; }

    public Guid ModuleId { get; set; }

    public Guid ZoneId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int TypeId { get; set; }

    public string? ResourceName { get; set; }

    public virtual ICollection<AisleState> AisleStates { get; set; } = new List<AisleState>();

    public virtual ICollection<Bay1> Bay1s { get; set; } = new List<Bay1>();

    public virtual ICollection<BreakpackLoop1> BreakpackLoop1InteractionAisles { get; set; } = new List<BreakpackLoop1>();

    public virtual ICollection<BreakpackLoop1> BreakpackLoop1TransitAisles { get; set; } = new List<BreakpackLoop1>();

    public virtual Level1 Level { get; set; } = null!;

    public virtual Module1 Module { get; set; } = null!;

    public virtual ICollection<PickupAndDeliveryStation1> PickupAndDeliveryStation1s { get; set; } = new List<PickupAndDeliveryStation1>();

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();

    public virtual AisleType Type { get; set; } = null!;

    public virtual Zone1 Zone { get; set; } = null!;
}
