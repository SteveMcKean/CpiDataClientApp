using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WarehousePackHandlingProfilesTemp
{
    public Guid WarehousePackId { get; set; }

    public int WarehousePackHandlingProfileTypeId { get; set; }
}
