using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PalletSequencingRequestState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PalletSequencingRequest> PalletSequencingRequests { get; set; } = new List<PalletSequencingRequest>();
}
