﻿using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundCartonRejectReason
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<InboundCarton> InboundCartons { get; set; } = new List<InboundCarton>();
}
