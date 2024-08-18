using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkusExtensionDataWork
{
    public int StagingSkusExtensionDataWorkSk { get; set; }

    public Guid Id { get; set; }

    public bool? IsCodeDated { get; set; }

    public bool? IsAutoDepal { get; set; }

    public string? ItemUpc { get; set; }

    public string? Description2 { get; set; }

    public string? Color { get; set; }

    public string? ItemSize { get; set; }

    public int? WarehousePerVendorPack { get; set; }

    public bool LithiumIndicator { get; set; }

    public int? Fhscode { get; set; }

    public int? SegregationCode { get; set; }

    public string? MaterialType { get; set; }

    public string? VendorStockNo { get; set; }

    public string? VendorName { get; set; }

    /// <summary>
    /// This CHECKSUM is calculated based on selected columns, while inserting from Sku.SkusTemp, used to detect changes against existing data in Sku.SkusExtensionData .
    /// </summary>
    public int? RowCheckSum { get; set; }

    public bool IsUpdate { get; set; }
}
