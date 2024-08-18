using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ConfigurationParameter1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Path { get; set; }

    public string? DisplayText { get; set; }

    public string Value { get; set; } = null!;

    public string FullyQualifiedTypeName { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsEditable { get; set; }

    public bool? IsRuntimeEditable { get; set; }

    public bool? IsActive { get; set; }

    public string? ValidationRegEx { get; set; }

    public string? ValidationRegexFailMessage { get; set; }

    public string? MinValue { get; set; }

    public string? MaxValue { get; set; }

    public int SortOrder { get; set; }

    public bool IsAuditable { get; set; }

    public int? AuditTrailGroup { get; set; }

    public int? AuditTrailEvent { get; set; }

    public int? AuditTrailReason { get; set; }
}
