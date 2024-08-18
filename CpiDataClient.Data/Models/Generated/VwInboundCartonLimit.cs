using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInboundCartonLimit
{
    public int InboundCartonDimensionLimits { get; set; }

    public double SystemMinLimitLength { get; set; }

    public double SystemMaxLimitLength { get; set; }

    public double SystemMinLimitWidth { get; set; }

    public double SystemMaxLimitWidth { get; set; }

    public double SystemMinLimitHeight { get; set; }

    public double SystemMaxLimitHeight { get; set; }

    public double SystemMinLimitWeight { get; set; }

    public double SystemMaxLimitWeight { get; set; }

    public double HeightOverWidthRatioMaxAllowed { get; set; }

    public double DimensionalVariantTolerance { get; set; }

    public double CpiweightTolerance { get; set; }

    public double Odvtolerance { get; set; }
}
