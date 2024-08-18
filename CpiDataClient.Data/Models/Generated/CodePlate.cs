﻿using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CodePlate
{
    public int CodePlateId { get; set; }

    public string? Name { get; set; }

    public int? CodePlateLevel { get; set; }

    public int? Xstart { get; set; }

    public int? Ystart { get; set; }

    public int? Xend { get; set; }

    public int? Yend { get; set; }

    public string? ChargerName { get; set; }
}
