using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ReplenishmentRequestsHistory
{
    public int ReplenishmentReqHistorySk { get; set; }

    public Guid ReplenishmentRequestId { get; set; }

    public Guid SkuId { get; set; }

    public int PalletCount { get; set; }

    public DateTime Deadline { get; set; }

    public int ReplenishmentPriority { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public int CartonCount { get; set; }

    public DateTimeOffset HistoryCreatedDate { get; set; }
}
