using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SegregationBayModel
{
    public int Id { get; set; }

    public int SegregationZoneId { get; set; }

    public int SubTier { get; set; }

    public int Level { get; set; }

    public int Aisle { get; set; }

    public int Number { get; set; }

    public string Side { get; set; } = null!;
}
