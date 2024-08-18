using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PalletSequencingRequest
{
    public Guid Id { get; set; }

    public int OutboundPalletNumber { get; set; }

    public string PalletFileName { get; set; } = null!;

    public string? SequenceFileName { get; set; }

    public DateTimeOffset ReceivedTime { get; set; }

    public DateTimeOffset? StartedTime { get; set; }

    public DateTimeOffset? CompletedTime { get; set; }

    public int State { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<PalletSequencingRequestError> PalletSequencingRequestErrors { get; set; } = new List<PalletSequencingRequestError>();

    public virtual PalletSequencingRequestState StateNavigation { get; set; } = null!;
}
