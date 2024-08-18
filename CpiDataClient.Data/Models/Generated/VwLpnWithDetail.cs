using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwLpnWithDetail
{
    public Guid Id { get; set; }

    public Guid LpnId { get; set; }

    public bool? IsInInventory { get; set; }
}
