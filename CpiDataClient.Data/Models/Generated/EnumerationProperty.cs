using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EnumerationProperty
{
    public Guid Id { get; set; }

    public string FullNamespace { get; set; } = null!;

    public string ParentClass { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string? Description { get; set; }

    public Guid EnumerationReferenceId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual EnumerationReference EnumerationReference { get; set; } = null!;
}
