using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonOverlappingSuspect
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public Guid? ShelfId { get; set; }
}
