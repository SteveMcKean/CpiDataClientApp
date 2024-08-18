using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ItemMaster
{
    public int StagingItemMasterSk { get; set; }

    public string CustomerItemCode { get; set; } = null!;

    public string? CaseUpc { get; set; }

    public string? ItemUpc { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemDescription2 { get; set; }

    public string? ItemColor { get; set; }

    public string? ItemSize { get; set; }

    public string? StrictRotation { get; set; }

    public string? WhpackWeight { get; set; }

    public string? WhpackLength { get; set; }

    public string? WhpackWidth { get; set; }

    public string? WhpackHeight { get; set; }

    public string? Ti { get; set; }

    public string? Hi { get; set; }

    public string? QtyPerVendorPack { get; set; }

    public string? HazMatCode { get; set; }

    public string? HazMatDesc { get; set; }

    public string? CrushableFactor { get; set; }

    public string? SystemAssignment { get; set; }

    public string? WarhouseArea { get; set; }

    public string? VendorNo { get; set; }

    public string? VendorDescription { get; set; }

    public string? LithiumIndicator { get; set; }

    public string? ItemStatus { get; set; }

    public string? Fhscode { get; set; }

    public string? SegregationCode { get; set; }

    public string? MaterialType { get; set; }

    public string? VendorStockNo { get; set; }

    public string? GoldDimIndicator { get; set; }

    public string? Symeligible { get; set; }

    public string? AutoDepalIndicator { get; set; }

    public string? RotationWindow { get; set; }

    public string? IsCodeDated { get; set; }

    public string? VendorName { get; set; }

    public string? Column34 { get; set; }

    public DateTimeOffset CreatedDateTime { get; set; }

    public int RejectReason { get; set; }

    public string? ImportFileName { get; set; }
}
