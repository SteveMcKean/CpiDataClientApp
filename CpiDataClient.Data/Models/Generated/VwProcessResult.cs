using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwProcessResult
{
    public int Id { get; set; }

    public string MessageType { get; set; } = null!;

    public string MessageCategory { get; set; } = null!;

    public string DeploymentStep { get; set; } = null!;

    public string DeploymentAction { get; set; } = null!;

    public string DeploymentCategory { get; set; } = null!;

    public int? RecordCount { get; set; }

    public string Message { get; set; } = null!;

    public int MessageTypeId { get; set; }

    public int MessageCategoryId { get; set; }

    public int DeploymentStepId { get; set; }

    public int DeploymentActionId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? DeploymentCategoryId { get; set; }
}
