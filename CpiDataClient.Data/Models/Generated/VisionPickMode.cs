using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VisionPickMode
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundRobotProperty> InboundRobotProperties { get; set; } = new List<InboundRobotProperty>();
}
