using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Bay1
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public int ShelfSide { get; set; }

    public int OffsetX { get; set; }

    public int OffsetY { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public Guid AisleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? ResourceName { get; set; }

    public virtual Aisle1 Aisle { get; set; } = null!;

    public virtual ICollection<Shelf1> Shelf1s { get; set; } = new List<Shelf1>();

    public virtual Side ShelfSideNavigation { get; set; } = null!;

    public virtual ICollection<ZoneBayModel> ZoneBayModels { get; set; } = new List<ZoneBayModel>();
}
