using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundDimensionalVariantsWork
{
    public int InboundDimensionalVariantsSk { get; set; }

    public Guid SkuId { get; set; }

    public int CartonLength { get; set; }

    public int CartonWidth { get; set; }

    public int CartonHeight { get; set; }

    public int Weight { get; set; }

    public int PostureCode { get; set; }

    public int DimensionLength { get; set; }

    public int DimensionWidth { get; set; }

    public int DimensionHeight { get; set; }

    public Guid? InboundRobotPropertyId { get; set; }

    public Guid? MatchingIdvid { get; set; }

    public Guid? MatchingOdvid { get; set; }
}
