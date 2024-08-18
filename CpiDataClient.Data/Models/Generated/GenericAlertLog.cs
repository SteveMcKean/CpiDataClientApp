using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class GenericAlertLog
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Severity { get; set; }

    public virtual AlertLog IdNavigation { get; set; } = null!;
}
