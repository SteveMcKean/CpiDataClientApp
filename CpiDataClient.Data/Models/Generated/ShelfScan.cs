using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShelfScan
{
    public Guid Id { get; set; }

    public Guid ShelfId { get; set; }

    public DateTimeOffset ScanTime { get; set; }

    public int NumberOfPicks { get; set; }

    public int NumberOfPlaces { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Shelf1 Shelf { get; set; } = null!;
}
