using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrder
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public bool IsPlanned { get; set; }

    public bool IsRecommendedBySystem { get; set; }

    public int Number { get; set; }

    public int AssetType { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public string CreatedUser { get; set; } = null!;

    public DateTimeOffset ModifiedTime { get; set; }

    public string ModifiedUser { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AssetType AssetTypeNavigation { get; set; } = null!;

    public virtual ICollection<WorkOrderAlertLog> WorkOrderAlertLogs { get; set; } = new List<WorkOrderAlertLog>();

    public virtual ICollection<WorkOrderChangeState> WorkOrderChangeStates { get; set; } = new List<WorkOrderChangeState>();

    public virtual ICollection<WorkOrderIssue> WorkOrderIssues { get; set; } = new List<WorkOrderIssue>();

    public virtual ICollection<WorkOrderNote> WorkOrderNotes { get; set; } = new List<WorkOrderNote>();
}
