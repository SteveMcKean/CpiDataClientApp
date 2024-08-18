using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwExceptionProcessingRequiredInfo
{
    public Guid Id { get; set; }

    public Guid CartonId { get; set; }

    public string Reason { get; set; } = null!;

    public string SubReason { get; set; } = null!;

    public string? ExtraInformation { get; set; }
}
