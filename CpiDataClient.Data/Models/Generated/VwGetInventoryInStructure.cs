using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwGetInventoryInStructure
{
    public Guid CartonId { get; set; }

    public int CartonVcp { get; set; }

    public int CartonSsp { get; set; }

    public int Eaches { get; set; }

    public int ZoneNumber { get; set; }

    public int LevelNumber { get; set; }

    public int AisleNumber { get; set; }

    public int BayNumber { get; set; }

    public int ShelfNumber { get; set; }

    public Guid SkuId { get; set; }

    public string? Name { get; set; }

    public string Sku { get; set; } = null!;

    public int SkuVcp { get; set; }

    public int SkuSsp { get; set; }

    public int ProductTypes { get; set; }

    public int SkuState { get; set; }

    public string? LicensePlateNumber { get; set; }

    public int AvailableCartons { get; set; }

    public int AvailableSupplyTotes { get; set; }

    public int AvailableEachesInSupplyTotes { get; set; }

    public int AvailableEaches { get; set; }

    public int AvailableTotes { get; set; }

    public int UnAvailableCartons { get; set; }

    public int UnAvailableSupplyTotes { get; set; }

    public int UnAvailableEaches { get; set; }

    public int UnAvailableTotes { get; set; }

    public int LpnunavailableCartons { get; set; }

    public int SkuunavailableCartons { get; set; }

    public int CartonUnavailableCartons { get; set; }

    public int ImholdEaches { get; set; }

    public int ImholdTotes { get; set; }

    public int ImholdCartons { get; set; }

    public int ImholdSupplyTotes { get; set; }

    public int SkuholdEaches { get; set; }

    public int SkuholdCartons { get; set; }

    public int SkuholdTotes { get; set; }

    public int CartonHoldCartons { get; set; }

    public int ContainerStateHoldSupplyTotes { get; set; }

    public int LpnholdCartons { get; set; }

    public int LpnholdEaches { get; set; }

    public int LpnholdTotes { get; set; }

    public int SuspectCartons { get; set; }

    public int SuspectSupplyTotes { get; set; }

    public int SuspectEaches { get; set; }

    public int SuspectTotes { get; set; }

    public int? CartonInners { get; set; }

    public int? SupplyToteInners { get; set; }

    public int AvailableOrderTotes { get; set; }

    public int UnAvailableOrderTotes { get; set; }

    public int ContainerStateHoldOrderTotes { get; set; }

    public int ImholdOrderTotes { get; set; }

    public int SuspectOrderTotes { get; set; }
}
