using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Scanner1
{
    public Guid Id { get; set; }

    public bool ProvidesWeight { get; set; }

    public bool ProvidesDimensions { get; set; }

    public bool CanReject { get; set; }

    public bool CanPrintRejectLabels { get; set; }

    public virtual Endpoint1 IdNavigation { get; set; } = null!;
}
