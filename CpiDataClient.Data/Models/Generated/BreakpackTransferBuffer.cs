using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BreakpackTransferBuffer
{
    public int Id { get; set; }

    public int? Number { get; set; }

    public int? Type { get; set; }

    public int? AisleId { get; set; }

    public int? LevelId { get; set; }

    public int? CartonHeightMax { get; set; }

    public int? BotTransferHeight { get; set; }

    public string? Name { get; set; }

    public int? GroupId { get; set; }

    public int? TransferBufferShelfId { get; set; }

    public int? SlotId { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Side { get; set; }

    public int? EdgeAlignment { get; set; }

    public int? Direction { get; set; }

    public string? CellName { get; set; }

    public int? Length { get; set; }

    public int? Width { get; set; }

    public string? MapNode { get; set; }

    public int? CenterY { get; set; }
}
