using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonScan
{
    public Guid Id { get; set; }

    public DateTimeOffset ScanTime { get; set; }

    public string ScanSource { get; set; } = null!;

    public int ScannerType { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public Guid CartonId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Carton Carton { get; set; } = null!;

    public virtual ScannerType ScannerTypeNavigation { get; set; } = null!;
}
