using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class MeteringGroupRef
{
    public int Id { get; set; }

    public int? DestinationId { get; set; }

    public string? MeteringGroupId { get; set; }
}
