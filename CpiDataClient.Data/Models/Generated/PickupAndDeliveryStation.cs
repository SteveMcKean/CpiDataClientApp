using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PickupAndDeliveryStation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CellName { get; set; }

    public int? GroupId { get; set; }

    public int? Direction { get; set; }

    public string? SubsystemId { get; set; }

    public int? Number { get; set; }

    public int? Type { get; set; }

    public int? AisleId { get; set; }

    public int? LevelId { get; set; }
}
