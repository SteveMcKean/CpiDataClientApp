using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwLatestCartonScan
{
    public Guid CartonId { get; set; }

    public DateTimeOffset? LastScanTime { get; set; }
}
