using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Module
{
    public int Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public int? StartPointX { get; set; }

    public int? StartPointY { get; set; }

    public int? EndPointX { get; set; }

    public int? EndPointY { get; set; }
}
