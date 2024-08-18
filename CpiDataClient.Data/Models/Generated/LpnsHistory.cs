using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LpnsHistory
{
    public int LpnsHistorySk { get; set; }

    public Guid Id { get; set; }

    public string LicensePlateNumber { get; set; } = null!;

    public Guid SkuId { get; set; }

    public DateTimeOffset? ReceivedDate { get; set; }

    public DateTimeOffset? InductionDate { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public int HoldState { get; set; }

    public bool IsInternal { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? StoreNumber { get; set; }

    public int? LabelTypeId { get; set; }

    public int? IsReceivingRequested { get; set; }

    public DateTimeOffset HistoryInsertDate { get; set; }
}
