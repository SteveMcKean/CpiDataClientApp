using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLift
{
    public int Number { get; set; }

    public string? Name { get; set; }

    public string? GroupId { get; set; }

    public string? CellName { get; set; }

    /// <summary>
    /// The Module Number for the CartonLift. Currently not provided in Structure File
    /// </summary>
    public int? ModuleNumber { get; set; }
}
