using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StructureStateReason
{
    public int RecordNumber { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public virtual ICollection<Annotation> Annotations { get; set; } = new List<Annotation>();

    public virtual ICollection<DrivewayState> DrivewayStates { get; set; } = new List<DrivewayState>();

    public virtual ICollection<ShelveState> ShelveStates { get; set; } = new List<ShelveState>();

    public virtual ICollection<TransferBuffersState> TransferBuffersStates { get; set; } = new List<TransferBuffersState>();
}
