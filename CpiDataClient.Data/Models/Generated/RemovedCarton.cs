using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class RemovedCarton
{
    public Guid CartonId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Carton Carton { get; set; } = null!;
}
