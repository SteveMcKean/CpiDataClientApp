using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WarehousePackPackageType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<WarehousePack> WarehousePacks { get; set; } = new List<WarehousePack>();
}
