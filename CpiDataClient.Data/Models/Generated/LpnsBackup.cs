using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LpnsBackup
{
    public string LicensePlateNumber { get; set; } = null!;

    public bool IsActive { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
