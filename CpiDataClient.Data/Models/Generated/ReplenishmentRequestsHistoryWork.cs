using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ReplenishmentRequestsHistoryWork
{
    public int ReplenishmentReqHistorySk { get; set; }

    public DateTimeOffset HistoryCreatedDate { get; set; }
}
