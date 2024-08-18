using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ReplenishmentRequest
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public int PalletCount { get; set; }

    public DateTime Deadline { get; set; }

    public int ReplenishmentPriority { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public int CartonCount { get; set; }
}
