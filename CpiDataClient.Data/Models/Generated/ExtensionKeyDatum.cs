using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ExtensionKeyDatum
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public string Type { get; set; } = null!;
}
