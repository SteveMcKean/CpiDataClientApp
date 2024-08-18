using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundCartonLabel
{
    public Guid Id { get; set; }

    public Guid CartonId { get; set; }

    public Guid? DestinationId { get; set; }

    public virtual Carton Carton { get; set; } = null!;

    public virtual LabelBase IdNavigation { get; set; } = null!;
}
