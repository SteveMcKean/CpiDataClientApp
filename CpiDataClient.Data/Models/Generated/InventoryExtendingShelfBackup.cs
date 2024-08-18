using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InventoryExtendingShelfBackup
{
    public Guid InventoryId { get; set; }

    public int OldOffsetY { get; set; }

    public int NewOffsetY { get; set; }

    public int OldWidth { get; set; }

    public int NewWidth { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
