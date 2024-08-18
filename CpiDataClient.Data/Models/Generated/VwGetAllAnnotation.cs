using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwGetAllAnnotation
{
    public int Id { get; set; }

    public string ResourceName { get; set; } = null!;

    public string ResourceType { get; set; } = null!;

    public string? StructureStateReasonName { get; set; }

    public string StateNote { get; set; } = null!;

    public DateTimeOffset AnnotationCreatedDate { get; set; }

    public DateTimeOffset? AnnotationModifiedDate { get; set; }

    public string? EnteredBy { get; set; }

    public string? UpdatedBy { get; set; }
}
