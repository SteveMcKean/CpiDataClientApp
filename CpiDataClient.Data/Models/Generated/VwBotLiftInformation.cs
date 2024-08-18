using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBotLiftInformation
{
    public string? Name { get; set; }

    public string? CarriageMapNodeName { get; set; }

    public int? OriginX { get; set; }

    public int? OriginY { get; set; }

    public int? Width { get; set; }

    public int? Depth { get; set; }

    public int ModuleNumber { get; set; }

    public Guid ModuleId { get; set; }
}
