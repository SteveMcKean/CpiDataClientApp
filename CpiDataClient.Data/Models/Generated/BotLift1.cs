using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotLift1
{
    public Guid Id { get; set; }

    public int? Number { get; set; }

    public string? Name { get; set; }

    public Guid ModuleId { get; set; }

    public int? OriginX { get; set; }

    public int? OriginY { get; set; }

    public int? Width { get; set; }

    public int? Depth { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Module1 Module { get; set; } = null!;
}
