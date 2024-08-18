using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ProcessLog
{
    public int Id { get; set; }

    public int DeploymentStepId { get; set; }

    public int? RecordCount { get; set; }

    public string Message { get; set; } = null!;

    public int MessageTypeId { get; set; }

    public int MessageCategoryId { get; set; }

    public int DeploymentActionId { get; set; }

    public int? DeploymentCategoryId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual DeploymentAction DeploymentAction { get; set; } = null!;

    public virtual DeploymentCategory? DeploymentCategory { get; set; }

    public virtual DeploymentStep DeploymentStep { get; set; } = null!;

    public virtual MessageCategory MessageCategory { get; set; } = null!;

    public virtual MessageType MessageType { get; set; } = null!;
}
