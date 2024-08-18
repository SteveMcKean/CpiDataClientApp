using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonsVcpsspbackup
{
    public Guid CartonId { get; set; }

    public int OldVcp { get; set; }

    public int NewVcp { get; set; }

    public int OldSsp { get; set; }

    public int NewSsp { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
