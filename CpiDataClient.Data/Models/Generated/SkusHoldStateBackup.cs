using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkusHoldStateBackup
{
    public Guid SkuId { get; set; }

    public string Sku { get; set; } = null!;

    public int OldHoldState { get; set; }

    public int NewHoldState { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
