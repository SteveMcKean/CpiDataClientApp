using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CodePlate1
{
    public Guid Id { get; set; }

    public int CodePlateId { get; set; }

    public string Name { get; set; } = null!;

    public Guid LevelId { get; set; }

    public int Xstart { get; set; }

    public int Ystart { get; set; }

    public int Xend { get; set; }

    public int Yend { get; set; }

    public string? ChargerName { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Level1 Level { get; set; } = null!;
}
