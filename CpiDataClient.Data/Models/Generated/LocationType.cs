using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LocationType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<StructureLocation> StructureLocations { get; set; } = new List<StructureLocation>();
}
