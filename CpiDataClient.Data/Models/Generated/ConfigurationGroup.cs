using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConfigurationGroup
{
    public Guid Id { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Path { get; set; }

    public string DisplayText { get; set; } = null!;

    public Guid? ParentGroupId { get; set; }

    public int SortOrder { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<ConfigurationParameter> ConfigurationParameters { get; set; } = new List<ConfigurationParameter>();
}
