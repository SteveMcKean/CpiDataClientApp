using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwDestinationInformation
{
    public Guid DestinationId { get; set; }

    public int? DestinationNumber { get; set; }

    public string? Name { get; set; }
}
