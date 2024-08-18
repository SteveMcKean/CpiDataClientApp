using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Driveway1
{
    public Guid Id { get; set; }

    public string Number { get; set; } = null!;

    public Guid? LevelId { get; set; }

    public Guid? ModuleId { get; set; }

    public string? Name { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? OriginPointX { get; set; }

    public int? OriginPointY { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? ResourceName { get; set; }

    public virtual ICollection<DrivewayState> DrivewayStates { get; set; } = new List<DrivewayState>();

    public virtual Level1? Level { get; set; }

    public virtual Module1? Module { get; set; }

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();
}
