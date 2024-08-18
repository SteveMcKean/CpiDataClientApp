using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AlertDefinition> AlertDefinitions { get; set; } = new List<AlertDefinition>();

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();
}
