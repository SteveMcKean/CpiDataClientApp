using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class RobotConfigurationProfile
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }

    public string Profile { get; set; } = null!;

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public bool? IsDefault { get; set; }

    public virtual ICollection<InboundRobotProperty> InboundRobotProperties { get; set; } = new List<InboundRobotProperty>();
}
