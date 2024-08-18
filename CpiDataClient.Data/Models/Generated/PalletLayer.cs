using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PalletLayer
{
    public int RecordNumber { get; set; }

    public Guid Id { get; set; }

    public Guid PalletId { get; set; }

    public int LayerNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int NumberOfLayers { get; set; }

    public virtual ICollection<InboundLpn> InboundLpns { get; set; } = new List<InboundLpn>();

    public virtual InboundPallet Pallet { get; set; } = null!;
}
