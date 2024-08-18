using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DeckLine1
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int Length { get; set; }

    public int Width { get; set; }

    public int Type { get; set; }

    public int Orientation { get; set; }

    public int OriginX { get; set; }

    public int OriginY { get; set; }

    public Guid LevelId { get; set; }

    public Guid? AisleId { get; set; }

    public Guid? DrivewayId { get; set; }

    public Guid DeckId { get; set; }

    public string ResourceName { get; set; } = null!;

    public int? DeckLineId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Deck1 Deck { get; set; } = null!;

    public virtual DeckLineType TypeNavigation { get; set; } = null!;
}
