using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferBufferType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();
}
