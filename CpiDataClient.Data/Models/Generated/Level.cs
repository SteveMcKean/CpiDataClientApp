using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Level
{
    public int Id { get; set; }

    public int Number { get; set; }

    public int Height { get; set; }

    public int LevelMapModelId { get; set; }

    public int? EndpointX { get; set; }

    public int? EndpointY { get; set; }

    public int? StartpointX { get; set; }

    public int? StartpointY { get; set; }

    public int? ModuleId { get; set; }
}
