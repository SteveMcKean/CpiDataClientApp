using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonLabelDatum
{
    public Guid Id { get; set; }

    public string? LabelData { get; set; }

    public Guid LabelId { get; set; }

    public string? BarCode { get; set; }
}
