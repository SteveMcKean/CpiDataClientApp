using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwCartonLiftTransferBufferInformation
{
    public int Number { get; set; }

    public int? CartonLiftNumber { get; set; }

    public string? VerticalConveyorSideName { get; set; }

    public int? VerticalId { get; set; }

    public int? TransferBufferType { get; set; }

    public string TransferBufferTypeName { get; set; } = null!;

    public string? TransferBufferName { get; set; }

    public int? VerticalTransferBufferGroupNumber { get; set; }

    public int? TransferHeight { get; set; }

    public int? OrderId { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public string? MapNode { get; set; }

    public int? CartonHeightMax { get; set; }

    public int? BotTransferHeight { get; set; }

    public int? ArmId { get; set; }

    public int? MapNodeOffset { get; set; }

    public int? Angle { get; set; }

    public string? EntranceNode { get; set; }

    public int? LevelNumber { get; set; }

    public Guid? LevelId { get; set; }

    public Guid CartonLiftId { get; set; }

    public Guid? EndpointId { get; set; }

    public Guid? VerticalConveyorSideId { get; set; }

    public int? PositionOnPnd { get; set; }

    public Guid? PickupAndDeliveryStationId { get; set; }

    public int? PositionFromStructure { get; set; }

    public int? Driveway { get; set; }

    public Guid? DrivewayId { get; set; }

    public int? CartonLiftGroupId { get; set; }
}
