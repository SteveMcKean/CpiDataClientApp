using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertExtension
{
    public int Id { get; set; }

    public int AlertItemId { get; set; }

    public int AlertExtensionFieldId { get; set; }

    public string? StringValue { get; set; }

    public virtual AlertExtensionField AlertExtensionField { get; set; } = null!;

    public virtual AlertItem AlertItem { get; set; } = null!;
}
