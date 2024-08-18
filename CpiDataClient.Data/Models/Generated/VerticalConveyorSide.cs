using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VerticalConveyorSide
{
    public Guid Id { get; set; }

    public Guid? CartonLiftId { get; set; }

    public string CustomerVerticalConveyorSideRef { get; set; } = null!;

    public virtual Endpoint1 IdNavigation { get; set; } = null!;

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();
}
