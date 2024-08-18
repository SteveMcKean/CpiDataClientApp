using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLiftArm
{
    public int Id { get; set; }

    public int? CartonLiftId { get; set; }

    public int? ArmId { get; set; }
}
