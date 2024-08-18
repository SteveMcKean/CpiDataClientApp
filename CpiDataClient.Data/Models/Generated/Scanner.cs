using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Scanner
{
    public int Id { get; set; }

    public string? EndpointId { get; set; }

    public bool? ProvidesWeight { get; set; }

    public bool? ProvidesDimensions { get; set; }

    public bool? CanReject { get; set; }

    public bool? CanPrintRejectLabels { get; set; }
}
