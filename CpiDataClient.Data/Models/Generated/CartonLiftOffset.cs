using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLiftOffset
{
    public int Id { get; set; }

    public int? CartonLiftId { get; set; }

    public int? ShelfExtend { get; set; }

    public int? ConveyorExtend { get; set; }

    public int? PickZoffset { get; set; }

    public int? PlaceZoffset { get; set; }
}
