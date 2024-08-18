using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SegregationZone
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool EnforceChimney { get; set; }
}
