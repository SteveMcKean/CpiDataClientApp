using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertItem
{
    public int Id { get; set; }

    public int AlertDefinitionId { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AlertDefinition AlertDefinition { get; set; } = null!;

    public virtual ICollection<AlertExtension> AlertExtensions { get; set; } = new List<AlertExtension>();
}
