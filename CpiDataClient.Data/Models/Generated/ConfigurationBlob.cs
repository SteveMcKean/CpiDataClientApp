using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConfigurationBlob
{
    public Guid Id { get; set; }

    public string? Key { get; set; }

    public string Value { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
