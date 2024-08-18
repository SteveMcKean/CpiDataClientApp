using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class MessageQueue
{
    public int Id { get; set; }

    public string Schema { get; set; } = null!;

    public string Table { get; set; } = null!;

    public Guid ObjectId { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset? MsgSentDate { get; set; }
}
