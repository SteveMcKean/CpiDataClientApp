using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class UpcsTemp
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ReconTypeAction { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
