using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ScheduledShift
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int ShiftStartDayOfWeek { get; set; }

    public DateTimeOffset ShiftStartTime { get; set; }

    public TimeOnly ShiftDuration { get; set; }

    public DateTimeOffset? ShiftDeleteTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<InboundForecast> InboundForecasts { get; set; } = new List<InboundForecast>();

    public virtual ShiftDayOfWeek ShiftStartDayOfWeekNavigation { get; set; } = null!;
}
