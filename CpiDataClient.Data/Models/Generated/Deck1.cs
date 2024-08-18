using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Deck1
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public int? BoundaryId { get; set; }

    public string? Name { get; set; }

    public int MinX { get; set; }

    public int MaxX { get; set; }

    public int MinY { get; set; }

    public int MaxY { get; set; }

    public string? ResourceName { get; set; }

    public Guid LevelId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<DeckLine1> DeckLine1s { get; set; } = new List<DeckLine1>();

    public virtual ICollection<DeckState> DeckStates { get; set; } = new List<DeckState>();

    public virtual Level1 Level { get; set; } = null!;

    public virtual DeckType TypeNavigation { get; set; } = null!;
}
