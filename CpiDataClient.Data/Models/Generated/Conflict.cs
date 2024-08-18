using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Conflict
{
    public Guid Id { get; set; }

    public DateTimeOffset ConflictTime { get; set; }

    public int FromCartonGroupType { get; set; }

    public int ToCartonGroupType { get; set; }

    public Guid? FromCartonGroupLocationGuid { get; set; }

    public Guid ToCartonGroupLocationGuid { get; set; }

    public bool IsResolved { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<ConflictCarton> ConflictCartons { get; set; } = new List<ConflictCarton>();
}
