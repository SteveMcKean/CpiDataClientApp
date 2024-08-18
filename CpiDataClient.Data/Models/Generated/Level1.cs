using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Level1
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public int Height { get; set; }

    public int Xmin { get; set; }

    public int Ymin { get; set; }

    public int Xmax { get; set; }

    public int Ymax { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? ResourceName { get; set; }

    public virtual ICollection<Aisle1> Aisle1s { get; set; } = new List<Aisle1>();

    public virtual ICollection<BotWarehouseState> BotWarehouseStates { get; set; } = new List<BotWarehouseState>();

    public virtual ICollection<BreakpackLoop1> BreakpackLoop1s { get; set; } = new List<BreakpackLoop1>();

    public virtual ICollection<CodePlate1> CodePlate1s { get; set; } = new List<CodePlate1>();

    public virtual ICollection<Deck1> Deck1s { get; set; } = new List<Deck1>();

    public virtual ICollection<Driveway1> Driveway1s { get; set; } = new List<Driveway1>();

    public virtual ICollection<LevelModuleState> LevelModuleStates { get; set; } = new List<LevelModuleState>();

    public virtual ICollection<TaskPlan> TaskPlans { get; set; } = new List<TaskPlan>();

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();
}
