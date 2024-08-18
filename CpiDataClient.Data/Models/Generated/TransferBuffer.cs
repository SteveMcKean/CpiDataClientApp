using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferBuffer
{
    public int Id { get; set; }

    public string? VerticalConveyorSideName { get; set; }

    public int? CartonLiftId { get; set; }

    public int? VerticalTransferBufferGroupId { get; set; }

    public int? Type { get; set; }

    public int? VerticalId { get; set; }

    public int? LevelId { get; set; }

    public int? TransferHeight { get; set; }

    public int? CartonHeightMax { get; set; }

    public int? BotTransferHeight { get; set; }

    public string? PickupAndDeliveryStationName { get; set; }

    public int? PositionFromStructure { get; set; }

    public string? Name { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }
}
