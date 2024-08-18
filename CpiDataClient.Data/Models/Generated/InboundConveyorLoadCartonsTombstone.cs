using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundConveyorLoadCartonsTombstone
{
    public int InbConvLoadsCtnsTombstoneSk { get; set; }

    public int RecordNumber { get; set; }

    public Guid Id { get; set; }

    public Guid CartonId { get; set; }

    public Guid InboundConveyorLoadId { get; set; }

    public int Position { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime TombstoneDate { get; set; }
}
