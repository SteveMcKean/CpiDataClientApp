using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertItemWork
{
    public int AlertItemId { get; set; }

    public DateTimeOffset? ModifiedDate { get; set; }
}
