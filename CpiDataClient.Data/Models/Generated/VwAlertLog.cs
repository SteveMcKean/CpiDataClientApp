using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwAlertLog
{
    public Guid Id { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public Guid AlertId { get; set; }

    public int AlertType { get; set; }

    public string AlertContext { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
