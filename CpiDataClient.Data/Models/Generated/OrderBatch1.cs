using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderBatch1
{
    public Guid Id { get; set; }

    public string CustomerBatchRef { get; set; } = null!;

    public int State { get; set; }

    public int WaveNumber { get; set; }

    public int? NonSymboticHeavyCaseCount { get; set; }

    public int? NonSymboticLightCaseCount { get; set; }

    public int? Priority { get; set; }

    public Guid SessionKey { get; set; }
}
