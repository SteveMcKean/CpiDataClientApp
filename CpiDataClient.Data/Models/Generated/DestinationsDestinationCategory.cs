using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationsDestinationCategory
{
    public Guid Id { get; set; }

    public Guid DestinationId { get; set; }

    public Guid DestinationCategoryId { get; set; }

    public int Sequence { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Destination Destination { get; set; } = null!;

    public virtual DestinationCategory DestinationCategory { get; set; } = null!;
}
