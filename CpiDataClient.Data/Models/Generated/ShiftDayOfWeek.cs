using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShiftDayOfWeek
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ScheduledShift> ScheduledShifts { get; set; } = new List<ScheduledShift>();
}
