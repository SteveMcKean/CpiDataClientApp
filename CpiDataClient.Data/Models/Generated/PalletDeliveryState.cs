using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PalletDeliveryState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundPallet> InboundPallets { get; set; } = new List<InboundPallet>();
}
