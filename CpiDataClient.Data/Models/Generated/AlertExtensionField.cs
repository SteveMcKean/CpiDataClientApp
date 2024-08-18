using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertExtensionField
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DataTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AlertExtension> AlertExtensions { get; set; } = new List<AlertExtension>();
}
