using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DuplicateAllocationMessage
{
    public int Id { get; set; }

    public Guid MessageId { get; set; }

    public DateTime CreatedDate { get; set; }
}
