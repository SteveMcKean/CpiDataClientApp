using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBreakpackInteractionAisleDatum
{
    public string? Name { get; set; }

    public int Number { get; set; }

    public Guid AisleId { get; set; }

    public int LowerLeftCornerX { get; set; }

    public int LowerLeftCornerY { get; set; }

    public int UpperRightCornerY { get; set; }

    public int UpperRightCornerX { get; set; }

    public string? BreakpackLiftOutboundPickupAndDeliveryStationName { get; set; }

    public string? BreakpackLiftInboundPickupAndDeliveryStationName { get; set; }

    public string? PutWallPickupAndDeliveryStationName { get; set; }

    public string? ShakeAndSealOutboundPickupAndDeliveryStationName { get; set; }

    public string? ShakeAndSealInboundPickupAndDeliveryStationName { get; set; }

    public string? BreakpackLiftBypassOutboundPickupAndDeliveryStationName { get; set; }
}
