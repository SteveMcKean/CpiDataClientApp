using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferBufferState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TransferBuffersState> TransferBuffersStates { get; set; } = new List<TransferBuffersState>();
}
