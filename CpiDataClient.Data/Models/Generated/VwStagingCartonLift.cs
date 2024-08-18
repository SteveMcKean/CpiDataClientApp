using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwStagingCartonLift
{
    public int Number { get; set; }

    public string? Name { get; set; }

    public string? GroupId { get; set; }

    public string? CellName { get; set; }

    public int? ModuleNumber { get; set; }
}
