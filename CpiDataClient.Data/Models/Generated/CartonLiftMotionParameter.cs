using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonLiftMotionParameter
{
    public int Id { get; set; }

    public int? CartonLiftId { get; set; }

    public string? Type { get; set; }

    public int? Speed { get; set; }

    public int? AccelTime { get; set; }

    public int? DecelTime { get; set; }

    public int? Profile { get; set; }
}
