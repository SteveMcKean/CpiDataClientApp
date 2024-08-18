using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ExceptionProcessingRequiredDetail
{
    public Guid Id { get; set; }

    public Guid CartonId { get; set; }

    public string Reason { get; set; } = null!;

    public string SubReason { get; set; } = null!;

    public string? ExtraInformation { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Carton Carton { get; set; } = null!;
}
