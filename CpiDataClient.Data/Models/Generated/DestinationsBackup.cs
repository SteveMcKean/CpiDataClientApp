using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationsBackup
{
    public int DestinationBackupSk { get; set; }

    public Guid Id { get; set; }

    public string? CustomerRef { get; set; }

    public string? ConveyorRef { get; set; }

    public int DestinationId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;
}
