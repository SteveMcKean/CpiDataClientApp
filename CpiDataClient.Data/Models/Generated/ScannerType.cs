using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ScannerType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CartonScan> CartonScans { get; set; } = new List<CartonScan>();
}
