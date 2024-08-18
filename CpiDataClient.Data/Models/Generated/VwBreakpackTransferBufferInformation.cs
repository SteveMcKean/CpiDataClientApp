using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBreakpackTransferBufferInformation
{
    public int? Number { get; set; }

    public int? TransferBufferType { get; set; }

    public string TransferBufferTypeName { get; set; } = null!;

    public string? TransferBufferName { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public string? MapNode { get; set; }

    public int? CartonHeightMax { get; set; }

    public int? BotTransferHeight { get; set; }

    public int? LevelNumber { get; set; }

    public int? GroupId { get; set; }

    public int? TransferBufferShelfId { get; set; }

    public int? SlotId { get; set; }

    public int? Side { get; set; }

    public int? EdgeAlignment { get; set; }

    public Guid LevelId { get; set; }

    public Guid AisleId { get; set; }

    public Guid PickupAndDeliveryStationId { get; set; }

    public string? PickupAndDeliveryStationName { get; set; }

    public int? PndDirection { get; set; }

    public int? CenterY { get; set; }
}
