using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SequencedDestinationCategory
{
    public int Id { get; set; }

    public int DestinationId { get; set; }

    public string DestinationCategoryId { get; set; } = null!;

    public int Sequence { get; set; }
}
