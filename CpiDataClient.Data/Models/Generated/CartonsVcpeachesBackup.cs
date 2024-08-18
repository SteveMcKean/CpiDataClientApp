using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonsVcpeachesBackup
{
    public Guid CartonId { get; set; }

    public int OldEaches { get; set; }

    public int NewEaches { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
