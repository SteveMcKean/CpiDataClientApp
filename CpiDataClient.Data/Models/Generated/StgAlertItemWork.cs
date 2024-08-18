using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StgAlertItemWork
{
    public int AlertItemId { get; set; }

    public DateTimeOffset? ModifiedDate { get; set; }
}
