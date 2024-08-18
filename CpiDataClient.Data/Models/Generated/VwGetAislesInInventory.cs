using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwGetAislesInInventory
{
    public Guid Id { get; set; }

    public Guid AisleId { get; set; }
}
