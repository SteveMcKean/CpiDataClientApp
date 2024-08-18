using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AnnotationsTombstone
{
    public int AnnotationsTombstoneSk { get; set; }

    public int Id { get; set; }

    public string ResourceName { get; set; } = null!;

    public int ResourceTypeId { get; set; }

    public string StateNote { get; set; } = null!;

    public int? StateReasonId { get; set; }

    public DateTimeOffset AnnotationCreatedDate { get; set; }

    public DateTimeOffset? AnnotationModifiedDate { get; set; }

    public string? EnteredBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime TombstoneDate { get; set; }
}
