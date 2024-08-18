using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOrderPalletSourceType
{
    public Guid OrderId { get; set; }

    public int PalletSourceType { get; set; }
}
