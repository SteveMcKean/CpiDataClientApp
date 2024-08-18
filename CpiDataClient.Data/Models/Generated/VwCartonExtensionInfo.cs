using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonExtensionInfo
{
    public Guid Id { get; set; }

    public Guid CartonId { get; set; }

    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public string Name { get; set; } = null!;
}
