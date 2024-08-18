using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConfigurationParameter
{
    public Guid Id { get; set; }

    public Guid? GroupId { get; set; }

    public string Name { get; set; } = null!;

    public string? Path { get; set; }

    public string DisplayText { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string FullyQualifiedTypeName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsEditable { get; set; }

    public bool IsRuntimeEditable { get; set; }

    public bool IsActive { get; set; }

    public string? ValidationRegEx { get; set; }

    public string? ValidationRegexFailMessage { get; set; }

    public string? MinValue { get; set; }

    public string? MaxValue { get; set; }

    public int SortOrder { get; set; }

    public bool IsAuditable { get; set; }

    public int? AuditTrailGroup { get; set; }

    public int? AuditTrailEvent { get; set; }

    public int? AuditTrailReason { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ConfigurationGroup? Group { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
