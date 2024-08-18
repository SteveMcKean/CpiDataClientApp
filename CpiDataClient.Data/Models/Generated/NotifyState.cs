using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class NotifyState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> OrderCaseStorageNotifyStateNavigations { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderCompletedNotifyStateNavigations { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderPlanUpdatedNotifyStateNavigations { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderPlannedNotifyStateNavigations { get; set; } = new List<Order>();
}
