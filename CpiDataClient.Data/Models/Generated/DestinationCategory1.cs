using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationCategory1
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? CanAssignObjective { get; set; }

    public bool? CanAssignOutbound { get; set; }

    public string? CustomerRef { get; set; }
}
