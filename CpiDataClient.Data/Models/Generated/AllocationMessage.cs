using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AllocationMessage
{
    public int Id { get; set; }

    public Guid MessageId { get; set; }

    public string Message { get; set; } = null!;

    public string MessageType { get; set; } = null!;

    public int Processed { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
