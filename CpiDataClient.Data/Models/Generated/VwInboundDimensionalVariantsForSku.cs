using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInboundDimensionalVariantsForSku
{
    public Guid Id { get; set; }

    public string Sku { get; set; } = null!;

    public int Length { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public int MaxCartonsPerPickFaceLongEdge { get; set; }

    public int MaxCartonsPerPickFaceShortEdge { get; set; }

    public int StoredOrientation { get; set; }

    public bool IsStorageEligible { get; set; }

    public Guid? ParentInboundDimensionalVariantId { get; set; }

    public string? MeasurementStation { get; set; }

    public int MeasuredBy { get; set; }
}
