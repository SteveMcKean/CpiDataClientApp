using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ZoneBayModelHistory
{
    public int ZoneBayModelHistorySk { get; set; }

    public int Id { get; set; }

    public int SegregationZoneId { get; set; }

    public int SubTier { get; set; }

    public Guid BayId { get; set; }

    public DateTimeOffset HistoryCreatedDate { get; set; }

    public string HistoryCreatedBy { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
