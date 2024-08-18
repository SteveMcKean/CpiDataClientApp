using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Module1
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public int StartPointX { get; set; }

    public int StartPointY { get; set; }

    public int EndPointX { get; set; }

    public int EndPointY { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Aisle1> Aisle1s { get; set; } = new List<Aisle1>();

    public virtual ICollection<BotLift1> BotLift1s { get; set; } = new List<BotLift1>();

    public virtual ICollection<CartonLift1> CartonLift1s { get; set; } = new List<CartonLift1>();

    public virtual ICollection<Driveway1> Driveway1s { get; set; } = new List<Driveway1>();

    public virtual ICollection<LevelModuleState> LevelModuleStates { get; set; } = new List<LevelModuleState>();

    public virtual ICollection<PickupAndDeliveryStation1> PickupAndDeliveryStation1s { get; set; } = new List<PickupAndDeliveryStation1>();
}
