using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderDetailExtension1
{
    public Guid Id { get; set; }

    public Guid OrderDetailId { get; set; }

    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public Guid SessionKey { get; set; }
}
