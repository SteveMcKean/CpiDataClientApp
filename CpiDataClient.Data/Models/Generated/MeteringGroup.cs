using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class MeteringGroup
{
    public Guid Id { get; set; }

    public string MeteringGroupId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Path { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Destination> Destinations { get; set; } = new List<Destination>();
}
