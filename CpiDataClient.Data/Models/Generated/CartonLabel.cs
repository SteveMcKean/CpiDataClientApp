using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLabel
{
    public Guid Id { get; set; }

    public Guid OrderDetailId { get; set; }

    public int? SequenceNumber { get; set; }

    public virtual LabelBase IdNavigation { get; set; } = null!;

    public virtual OrderDetail OrderDetail { get; set; } = null!;

    public virtual ICollection<OutboundCarton> OutboundCartons { get; set; } = new List<OutboundCarton>();
}
