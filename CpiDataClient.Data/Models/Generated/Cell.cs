using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Cell
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? CellGroup { get; set; }

    public string Direction { get; set; } = null!;
}
