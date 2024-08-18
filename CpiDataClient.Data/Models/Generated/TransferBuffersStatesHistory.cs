using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferBuffersStatesHistory
{
    public int TransferBuffersStateHistorySk { get; set; }

    public Guid TransferBufferId { get; set; }

    public int State { get; set; }

    public DateTimeOffset StateChangeDateTime { get; set; }

    public bool? IsOnline { get; set; }

    public DateTimeOffset ToDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTimeOffset HistoryCreatedDate { get; set; }

    public string HistoryCreatedBy { get; set; } = null!;

    public int? StateReasonId { get; set; }

    public string? StateNote { get; set; }
}
