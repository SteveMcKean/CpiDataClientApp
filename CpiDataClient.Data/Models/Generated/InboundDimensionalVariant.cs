using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundDimensionalVariant
{
    public int RecordNumber { get; set; }

    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public DateTimeOffset TaughtDate { get; set; }

    public bool ManualEntry { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public bool IsGolden { get; set; }

    public Guid? InboundRobotPropertyId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? MaxCartonsPerPickFaceLongEdge { get; set; }

    public int? MaxCartonsPerPickFaceShortEdge { get; set; }

    public int? StoredOrientation { get; set; }

    public bool IsStorageEligible { get; set; }

    public Guid? ParentInboundDimensionalVariantId { get; set; }

    public string? MeasurementStation { get; set; }

    public int MeasuredBy { get; set; }

    public bool? TipOverridden { get; set; }

    public string? TipOverrideUserName { get; set; }

    public int? TipOverrideReassonCode { get; set; }

    public virtual InboundRobotProperty? InboundRobotProperty { get; set; }

    public virtual ICollection<InboundDimensionalVariant> InverseParentInboundDimensionalVariant { get; set; } = new List<InboundDimensionalVariant>();

    public virtual MeasuredBy MeasuredByNavigation { get; set; } = null!;

    public virtual InboundDimensionalVariant? ParentInboundDimensionalVariant { get; set; }

    public virtual Sku Sku { get; set; } = null!;

    public virtual LeadEdgeOrientation? StoredOrientationNavigation { get; set; }

    public virtual TipOverrideReasonCode? TipOverrideReassonCodeNavigation { get; set; }
}
