using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwLatestShelfScan
{
    public Guid ShelfId { get; set; }

    public DateTimeOffset? LastScanTime { get; set; }
}
