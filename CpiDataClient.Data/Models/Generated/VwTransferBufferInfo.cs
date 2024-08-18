using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwTransferBufferInfo
{
    public Guid Id { get; set; }

    public Guid? CartonLiftId { get; set; }

    public Guid? LevelId { get; set; }

    public string? CartonLiftName { get; set; }

    public string? CellName { get; set; }

    public string TransferBufferType { get; set; } = null!;

    public string? TransferBufferName { get; set; }

    public int VerticalTransferBufferGroupNumber { get; set; }

    public int PositionOnPnd { get; set; }

    public int OrderId { get; set; }

    public int VerticalId { get; set; }

    public int? ArmId { get; set; }

    public int? GlobalXmm { get; set; }

    public int? GlobalYmm { get; set; }

    public int? MaxCartonHeightmm { get; set; }

    public int? Driveway { get; set; }

    public Guid? DrivewayId { get; set; }

    public int? GroupId { get; set; }

    public int? TransferBufferShelfId { get; set; }

    public int? SlotId { get; set; }

    public int Xcoordinate { get; set; }

    public int Ycoordinate { get; set; }

    public string? Side { get; set; }

    public string? EdgeAlignment { get; set; }

    public int? BotTransferHeight { get; set; }

    public int? LowerLeftCornerX { get; set; }

    public int? LowerLeftCornerY { get; set; }

    public int? UpperRightCornerX { get; set; }

    public int? UpperRightCornerY { get; set; }
}
