using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PalletBaseType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int OverhangLength { get; set; }

    public int OverhangWidth { get; set; }

    public int MaxWeight { get; set; }

    public int? MaxHeight { get; set; }

    public int WeightOfBase { get; set; }

    public bool IsActive { get; set; }

    public bool IsInbound { get; set; }

    public bool IsOutbound { get; set; }

    public bool? IsModified { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public int MaxWeightFloor { get; set; }

    public int MaxWeightCeiling { get; set; }

    public int MaxHeightFloor { get; set; }

    public int MaxHeightCeiling { get; set; }

    public int OverhangLengthFloor { get; set; }

    public int OverhangLengthCeiling { get; set; }

    public int OverhangWidthFloor { get; set; }

    public int OverhangWidthCeiling { get; set; }

    public bool? IsDefaultInbound { get; set; }

    public bool? IsDefaultOutbound { get; set; }

    public virtual ICollection<InboundPallet> InboundPallets { get; set; } = new List<InboundPallet>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OutboundPallet> OutboundPallets { get; set; } = new List<OutboundPallet>();
}
