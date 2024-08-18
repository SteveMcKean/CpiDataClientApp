using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotLift
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CarriageMapNodeName { get; set; }

    public int? OriginX { get; set; }

    public int? OriginY { get; set; }

    public int? Width { get; set; }

    public int? Depth { get; set; }
}
