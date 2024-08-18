using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonRejectReason
{
    /// <summary>
    /// This ID value is bit-masked INT, which goes exponentially, i.e. 4,8,6,32... up to ~2B as INT. The SUM of any single one or combo of this ID value is written to RejectReason on Inbound.InboundCartons. 
    /// </summary>
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
