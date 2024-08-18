using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Parameter
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public string KeyName { get; set; } = null!;

    public string KeyValue { get; set; } = null!;

    public string? KeyValueProperty { get; set; }

    public bool IsActive { get; set; }
}
