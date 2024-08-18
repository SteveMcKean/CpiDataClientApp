using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderExtension1
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public Guid SessionKey { get; set; }
}
