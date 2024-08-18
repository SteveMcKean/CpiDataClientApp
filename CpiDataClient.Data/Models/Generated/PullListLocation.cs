using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PullListLocation
{
    public int Id { get; set; }

    public int Score { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public DateTime LookBackStart { get; set; }

    public DateTime LookBackEnd { get; set; }

    public int Level { get; set; }

    public int MinX { get; set; }

    public int MaxX { get; set; }

    public int MinY { get; set; }

    public int MaxY { get; set; }

    public DateTime? LastMaintenance { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
