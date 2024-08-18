using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwConfigurationGroupRanked
{
    public int Id { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Path { get; set; }

    public string? DisplayText { get; set; }

    public int SortOrder { get; set; }

    public bool? IsActive { get; set; }
}
