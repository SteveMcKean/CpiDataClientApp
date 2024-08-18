using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EnumerationReferenceValue
{
    public Guid Id { get; set; }

    public int IntValue { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? CustomerReference { get; set; }

    public string? FriendlyName { get; set; }

    public bool? IsActive { get; set; }

    public Guid EnumerationReferenceId { get; set; }

    public Guid? Parent { get; set; }

    public int? SortOrder { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual EnumerationReference EnumerationReference { get; set; } = null!;
}
