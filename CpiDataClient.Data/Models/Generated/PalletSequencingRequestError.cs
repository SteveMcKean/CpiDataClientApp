using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PalletSequencingRequestError
{
    public Guid Id { get; set; }

    public string ComponentName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTimeOffset Time { get; set; }

    public Guid PalletSequencingRequestId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual PalletSequencingRequest PalletSequencingRequest { get; set; } = null!;
}
