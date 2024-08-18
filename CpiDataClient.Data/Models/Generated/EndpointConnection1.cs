using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EndpointConnection1
{
    public Guid Id { get; set; }

    public Guid InEndpointId { get; set; }

    public Guid OutEndpointId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
