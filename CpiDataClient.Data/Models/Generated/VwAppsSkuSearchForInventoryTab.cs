using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwAppsSkuSearchForInventoryTab
{
    public Guid Id { get; set; }

    public string Sku { get; set; } = null!;

    public int AllergenTypeId { get; set; }

    public string? Name { get; set; }

    public int ProductTypes { get; set; }

    public int SlottedState { get; set; }

    public bool IsTaught { get; set; }

    public bool IsEligible { get; set; }

    public int PackagingTypeId { get; set; }

    public int Vcp { get; set; }

    public int Ssp { get; set; }

    public int HoldState { get; set; }

    public bool IsFridgePack { get; set; }

    public bool IsPressurized { get; set; }

    public int PalletizationGroupTypeId { get; set; }

    public int BreakPackEligible { get; set; }

    public int CasesPerLayer { get; set; }

    public int LayersPerPallet { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool? IsAutoDepal { get; set; }

    public string? Upcid { get; set; }

    public string PackagingTypeName { get; set; } = null!;

    public string PalletizationGroupType { get; set; } = null!;
}
