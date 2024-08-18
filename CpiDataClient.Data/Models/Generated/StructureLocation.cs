using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StructureLocation
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public int? LocationType { get; set; }

    public int? StartPointX { get; set; }

    public int? StartPointY { get; set; }

    public int? EndPointX { get; set; }

    public int? EndPointY { get; set; }

    public Guid? LevelId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<BotAlertLog> BotAlertLogs { get; set; } = new List<BotAlertLog>();

    public virtual LocationType? LocationTypeNavigation { get; set; }

    public virtual ICollection<LocationWorkOrder> LocationWorkOrders { get; set; } = new List<LocationWorkOrder>();
}
