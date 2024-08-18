using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LiftLoadCartonsTombstone
{
    public int TransferBufferLoadCartonsTombstoneSk { get; set; }

    public Guid Id { get; set; }

    public int Position { get; set; }

    public Guid CartonId { get; set; }

    public Guid LiftLoadId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime TombstoneDate { get; set; }
}
