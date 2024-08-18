using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkusExtensionDataHistory
{
    public int SkuExtensionDataHistorySk { get; set; }

    public Guid Id { get; set; }

    public bool? IsCodeDated { get; set; }

    public bool? IsAutoDepal { get; set; }

    public string? ItemUpc { get; set; }

    public string? Description2 { get; set; }

    public string? Color { get; set; }

    public string? ItemSize { get; set; }

    public int? WarehousePerVendorPack { get; set; }

    public bool? LithiumIndicator { get; set; }

    public int? Fhscode { get; set; }

    public int? SegregationCode { get; set; }

    public string? MaterialType { get; set; }

    public string? VendorStockNo { get; set; }

    public string? VendorName { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTimeOffset HistoryDate { get; set; }
}
