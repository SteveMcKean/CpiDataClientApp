using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderDetailCartonLabel
{
    public Guid Id { get; set; }

    public string? LabelData { get; set; }

    public string? BarCode { get; set; }

    public bool IsActive { get; set; }

    public Guid OrderDetailId { get; set; }

    public int? SequenceNumber { get; set; }

    public Guid SessionKey { get; set; }
}
