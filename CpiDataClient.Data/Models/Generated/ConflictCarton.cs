using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConflictCarton
{
    public Guid Id { get; set; }

    public Guid ConflictId { get; set; }

    public Guid CartonId { get; set; }

    public int? CartonGroupNumber { get; set; }

    public bool IsFrom { get; set; }

    public bool IsResolved { get; set; }

    public int? XPos { get; set; }

    public int? YPos { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Conflict Conflict { get; set; } = null!;
}
