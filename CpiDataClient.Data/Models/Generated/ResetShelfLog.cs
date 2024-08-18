using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ResetShelfLog
{
    public int Id { get; set; }

    public Guid ShelfId { get; set; }

    public DateTimeOffset ResetShelfDate { get; set; }
}
