using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BreakpackLoop1
{
    public Guid Id { get; set; }

    public Guid LevelId { get; set; }

    public string Name { get; set; } = null!;

    public string CellName { get; set; } = null!;

    public int CellSideId { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int OriginPointX { get; set; }

    public int OriginPointY { get; set; }

    public Guid TransitAisleId { get; set; }

    public Guid InteractionAisleId { get; set; }

    public string TurnAroundDeckName { get; set; } = null!;

    public int TurnAroundDeckId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Side CellSide { get; set; } = null!;

    public virtual Aisle1 InteractionAisle { get; set; } = null!;

    public virtual Level1 Level { get; set; } = null!;

    public virtual Aisle1 TransitAisle { get; set; } = null!;
}
