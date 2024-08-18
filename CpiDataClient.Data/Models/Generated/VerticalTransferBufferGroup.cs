using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VerticalTransferBufferGroup
{
    public int Id { get; set; }

    public int? Number { get; set; }

    public int? ArmId { get; set; }

    public int? CartonLiftId { get; set; }

    public int? OrderId { get; set; }

    public string? MapNode { get; set; }

    public int? MapNodeOffset { get; set; }

    public int? Angle { get; set; }

    public string? EntranceNode { get; set; }

    public int? PositionOnPnD { get; set; }

    public int? Driveway { get; set; }

    public string? DrivewayName { get; set; }

    public int? CartonLiftGroupId { get; set; }
}
