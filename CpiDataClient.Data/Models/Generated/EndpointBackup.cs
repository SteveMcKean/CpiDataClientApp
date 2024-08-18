using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EndpointBackup
{
    public int EndpointBackupSk { get; set; }

    public Guid Id { get; set; }

    public string? EndpointId { get; set; }

    public string? CustomerEndpointRef { get; set; }

    public string? DisplayName { get; set; }

    public Guid? SubsystemId { get; set; }

    public bool RequiresWmsnotification { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedOn { get; set; }
}
