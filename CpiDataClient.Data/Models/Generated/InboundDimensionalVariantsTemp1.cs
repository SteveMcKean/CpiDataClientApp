using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundDimensionalVariantsTemp1
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public Guid? InboundRobotPropertyId { get; set; }

    public DateTimeOffset TaughtDate { get; set; }

    public bool ManualEntry { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public bool IsGolden { get; set; }

    public int? MaxCartonsPerPickFaceLongEdge { get; set; }

    public int? MaxCartonsPerPickFaceShortEdge { get; set; }

    public int? StoredOrientation { get; set; }

    public bool IsStorageEligible { get; set; }

    public Guid? ParentInboundDimensionalVariantId { get; set; }

    public string? MeasurementStation { get; set; }

    public int MeasuredBy { get; set; }
}
