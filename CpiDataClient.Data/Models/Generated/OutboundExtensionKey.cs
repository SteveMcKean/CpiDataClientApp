using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundExtensionKey
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<OutboundExtension> OutboundExtensions { get; set; } = new List<OutboundExtension>();
}
