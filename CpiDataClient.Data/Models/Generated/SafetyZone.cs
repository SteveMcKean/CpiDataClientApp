using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SafetyZone
{
    public int Id { get; set; }

    public int Number { get; set; }

    public int? AisleId { get; set; }

    public int? ModuleId { get; set; }

    public string? Name { get; set; }

    public int? ZoneType { get; set; }

    public string? ZoneTypeName { get; set; }

    public int? ZoneNumber { get; set; }
}
