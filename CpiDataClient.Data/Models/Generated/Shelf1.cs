using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Shelf1
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public int ShelfSide { get; set; }

    public int OffsetX { get; set; }

    public int OffsetY { get; set; }

    public int OffsetZ { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public Guid BayId { get; set; }

    public int MaxStorageWeight { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? ResourceName { get; set; }

    public virtual Bay1 Bay { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<ShelfScan> ShelfScans { get; set; } = new List<ShelfScan>();

    public virtual Side ShelfSideNavigation { get; set; } = null!;

    public virtual ShelveState? ShelveState { get; set; }

    public virtual ICollection<TaskPlan> TaskPlanLoadShelves { get; set; } = new List<TaskPlan>();

    public virtual ICollection<TaskPlan> TaskPlanUnloadShelves { get; set; } = new List<TaskPlan>();
}
