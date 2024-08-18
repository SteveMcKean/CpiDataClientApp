using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ResourceType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Annotation> Annotations { get; set; } = new List<Annotation>();
}
