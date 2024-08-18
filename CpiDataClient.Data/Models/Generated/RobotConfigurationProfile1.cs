using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class RobotConfigurationProfile1
{
    public int RecordNumber { get; set; }

    public int Id { get; set; }

    public string? Name { get; set; }

    public string? DisplayName { get; set; }

    public string? Description { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsActive { get; set; }

    public string? Profile { get; set; }

    public bool IsDefault { get; set; }
}
