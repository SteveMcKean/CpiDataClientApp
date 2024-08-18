using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ScratchReason
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();
}
