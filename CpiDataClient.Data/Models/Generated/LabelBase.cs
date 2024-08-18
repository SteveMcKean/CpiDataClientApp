using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LabelBase
{
    public Guid Id { get; set; }

    public string? LabelData { get; set; }

    public string? BarCode { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual CartonLabel? CartonLabel { get; set; }

    public virtual InboundCartonLabel? InboundCartonLabel { get; set; }
}
