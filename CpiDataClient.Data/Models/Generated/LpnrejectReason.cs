using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LpnrejectReason
{
    public int RecordNumber { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public virtual ICollection<InboundLpn> InboundLpns { get; set; } = new List<InboundLpn>();
}
