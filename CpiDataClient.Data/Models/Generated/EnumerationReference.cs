using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EnumerationReference
{
    public Guid Id { get; set; }

    public string FullNamespace { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<EnumerationProperty> EnumerationProperties { get; set; } = new List<EnumerationProperty>();

    public virtual ICollection<EnumerationReferenceValue> EnumerationReferenceValues { get; set; } = new List<EnumerationReferenceValue>();
}
