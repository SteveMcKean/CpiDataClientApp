using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLift1
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public string? CellName { get; set; }

    public string? CartonLiftGroupNumber { get; set; }

    public Guid ModuleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<CartonLiftState> CartonLiftStates { get; set; } = new List<CartonLiftState>();

    public virtual Module1 Module { get; set; } = null!;

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();
}
